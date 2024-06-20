using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;

namespace takvimUygulaması
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        baglanti bag = new baglanti();
        NotifyIcon notify_Icon = new NotifyIcon();
        int kapat = 0;


        #region Sil
        private void sil_Buton_Click(object sender, EventArgs e)
        {

            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sectarih = monthCalendar1.SelectionStart.ToString("d");
        
            string sil = $"delete from notlar where notId = \'{deger}\'";
            SqlCommand komut = new SqlCommand(sil, bag.conn);
            bag.conn.Open();
            komut.ExecuteNonQuery();
            bag.conn.Close();
            yenile(sectarih);
        }
        #endregion

        #region Kaydet
        private void kaydet_buton_Click(object sender, EventArgs e)
        {
            try
            {
                bag.conn.Open();
                notEkle();
                bag.conn.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            yenile();
        }
        #endregion

        #region Class'lar
        private void notEkle()
        {
            string bas = $"{saatBİlgi.Value}:{dakikaBilgi.Value}";
            string son = $"{bitisSaatBilgi.Value}:{bitisDakikaBilgi.Value}";
            string kayit = $"insert into notlar(kId,olay,not_icerik,tarih,bas_saat,son_saat) " +
                $"values " +
                $"(@kId,@olay,@not_icerik,@tarih,@bas_saat,@son_saat)";

            SqlCommand komut = new SqlCommand(kayit, bag.conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@kID", Form1.id);
            komut.Parameters.AddWithValue("@olay", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@not_icerik", richTextBox1.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString("d"));
            komut.Parameters.AddWithValue("@bas_saat", bas);
            komut.Parameters.AddWithValue("@son_saat", son);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            temizle();
        }
        private void temizle()
        {
            dateTimePicker1.Value = DateTime.Now;
            richTextBox1.Text = "";
            comboBox1.Text = "";
        }
        private void yenile()
        {
            bag.conn.Open();
            SqlDataAdapter komut = new SqlDataAdapter($"select notId,olay,not_icerik,tarih,bas_saat,son_saat from notlar where kId =\'{Form1.id}\' and tarih=\'{DateTime.Now.ToString("d")}\' ", bag.conn);
            DataSet ds = new DataSet();
            
            komut.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bag.conn.Close();
        }
        private void yenile(string tarih)
        {
            bag.conn.Open();
            SqlDataAdapter komut = new SqlDataAdapter($"select notId,olay,not_icerik,tarih,bas_saat,son_saat from notlar where kId =\'{Form1.id}\' and tarih=\'{tarih}\' ", bag.conn);
            DataSet ds = new DataSet();
            komut.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bag.conn.Close();
        }
        #endregion

        #region Güncelle
        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            string deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sectarih = monthCalendar1.SelectionStart.ToString("d");
            
            bag.conn.Open();

            string guncelle = $"update notlar set " +
                $"olay =\'{comboBox1.SelectedItem.ToString()}\'," +
                $"not_icerik=\'{richTextBox1.Text}\'," +
                $"tarih=\'{dateTimePicker1.Value.ToString("d")}\'," +
                $"bas_saat=\'{saatBİlgi.Value}:{dakikaBilgi.Value}\'," +
                $"son_saat=\'{bitisSaatBilgi.Value}:{bitisDakikaBilgi.Value}\'" +
                $"where notId = {deger}";


            SqlCommand komut = new SqlCommand(guncelle, bag.conn);
            komut.ExecuteNonQuery();
            bag.conn.Close();
            yenile(sectarih);
        }
        #endregion

        #region DataGridView,FormClosing,MonthCalendar1,LoadOlayı
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guncelle_buton.Enabled = true;
            sil_Buton.Enabled = true;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string olay = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string icerik = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string tarih = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string bas_saat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string son_saat = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string[] bas_gecici = bas_saat.Split(':'); ;
            string[] son_gecici = son_saat.Split(':'); ;
            comboBox1.Text = olay;
            richTextBox1.Text = icerik;
            dateTimePicker1.Value = Convert.ToDateTime(tarih);
            saatBİlgi.Value = Convert.ToInt32(bas_gecici[0]);
            dakikaBilgi.Value = Convert.ToInt32(bas_gecici[1]);
            bitisSaatBilgi.Value = Convert.ToInt32(son_gecici[0]);
            bitisDakikaBilgi.Value = Convert.ToInt32(son_gecici[1]);

        }
        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapat == 1)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                NotifyIcon();
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string sectarih = monthCalendar1.SelectionStart.ToString("d");
            yenile(sectarih);
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'takvimDataSet2.notlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            try
            {
                //notification tanımlıyoruz
                notify_Icon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

                var tarih = DateTime.Now.ToString("d");
                saatBİlgi.Value = Convert.ToInt32(DateTime.Now.Hour);
                dakikaBilgi.Value = Convert.ToInt32(DateTime.Now.Minute);
                bitisSaatBilgi.Value = Convert.ToInt32(DateTime.Now.Hour);
                bitisDakikaBilgi.Value = Convert.ToInt32(DateTime.Now.Minute);
                yenile();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        #endregion

        #region Bildirim 
        private void anasayfa_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                NotifyIcon();
        }
        void NotifyIcon()
        {
            this.Hide();
            notify_Icon.Visible = true;
            notify_Icon.Text = "Takvim Uygulaması";
            notify_Icon.BalloonTipTitle = "Takvim uygulaması arka planda çalışıyor";
            notify_Icon.BalloonTipText = "Program sağ alt köşede konumlandı.";
            notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
            notify_Icon.ShowBalloonTip(2000);
            notify_Icon.ContextMenuStrip = contextMenuStrip1;
            // notifyIcon için event ataması yaptık
            notify_Icon.MouseDoubleClick += new MouseEventHandler(notify_Icon_MouseDoubleClick);
        }

        void notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }
        void NotifyBildirim(string baslik, string mesaj)
        {
            notify_Icon.BalloonTipTitle = baslik;
            notify_Icon.BalloonTipText = mesaj;
            notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
            notify_Icon.ShowBalloonTip(3000);
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapat = 1;
            Application.Exit();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notify_Icon.Visible = false;
        }
        #endregion
    }
}
