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


namespace takvimUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int id = 0;
        kayit kayitForm = new kayit();
        baglanti bag = new baglanti();
        anasayfa ana = new anasayfa();
        private void button1_Click(object sender, EventArgs e)
        {
                bag.conn.Close();
            try
            {

                bag.conn.Open();
                string nickname;
                string password;
                nickname = txt_kadi.Text;
                password = txt_sifre.Text;
                if (nickname == "" && password == "")
                {
                    MessageBox.Show("Lütfen alanları boş bırakmayınız ve ya doğru biçimde giriniz.");
                }
                else
                {

                    SqlCommand komut = new SqlCommand("select * from kul where kul_Adi ='" + nickname + "'and kul_Sif='" + password + "'", bag.conn);
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        id = Convert.ToInt32(oku["kId"]);
                        this.Hide();
                        ana.Show();
                    }
                    else MessageBox.Show("Böyle bir kullanıcı bulunamadı!");

                }

                bag.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:"+ ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayitForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bag.conn.Close();
        }
    }
}
