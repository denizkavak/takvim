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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        baglanti bag = new baglanti();
        private void kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text != null)&& (textBox2.Text != null)&& (textBox3.Text != null)&& (textBox4.Text != null)
                    && (textBox5.Text != null)&&(textBox5.Text.Length ==11)&& (textBox6.Text != null) && (textBox7.Text != null)
                    && (richTextBox1.Text != null) && (comboBox1.Text != null))
                {
                    bag.conn.Open();
                    kayitEkle();
                }
                else
                    MessageBox.Show($"Lütfen alanları kontrol ediniz!!!" +
                        $"\nTüm alanları doldurmak zorundasınız." +
                        $"\nT.C kimlik numarası 11 haneli olmak zorundadır." +
                        $"\nTelefon Numarası başında \'0\' olmadan yazılmalıdır.");
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Hatalı İşlem Gerçekleştirdiniz! Lütfen kontrol ediniz.\n"+ hata.Message.ToString());
            }
            bag.conn.Close();
        }

        private void kayitEkle()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && richTextBox1.Text == "")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!");
            }
            else
            {

                string kayit = "insert into kul(adi,soyadi,kul_Adi,kul_Sif,tc,telNo,mail,adres,kTip) values (@adi,@soyadi,@kul_Adi,@kul_Sif,@tc,@telNo,@mail,@adres,@kTip)";

                SqlCommand komut = new SqlCommand(kayit, bag.conn);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@adi", textBox1.Text);
                komut.Parameters.AddWithValue("@soyadi", textBox2.Text);
                komut.Parameters.AddWithValue("@kul_Adi", textBox3.Text);
                komut.Parameters.AddWithValue("@kul_sif", textBox4.Text);
                komut.Parameters.AddWithValue("@tc", textBox5.Text);
                komut.Parameters.AddWithValue("@telNo", textBox6.Text);
                komut.Parameters.AddWithValue("@mail", textBox7.Text);
                komut.Parameters.AddWithValue("@adres", richTextBox1.Text);
                komut.Parameters.AddWithValue("@kTip", 1);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!!!");
            }
        }
        int gosterGizle = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (gosterGizle == 0)
            {
                textBox4.PasswordChar = default;
                gosterGizle = 1;
            }
            else
            {
                textBox4.PasswordChar = '*';
                gosterGizle = 0;
            }
        }
    }
}
