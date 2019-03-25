using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class kullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        public kullaniciGirisi()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection beri = sqlBaglan.baglan();
            string komut = "Select *From kullaniciGiris where kullaniciAdi=@p1 and sifre=@p2";
            SqlCommand beri1 = new SqlCommand(komut, beri);
            beri1.Parameters.Add("@p1", textBox1.Text);
            beri1.Parameters.Add("@p2", textBox2.Text);
            SqlDataReader oku = beri1.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Giris Basarili");
               // Form1 beri2 = new Form1();
               // beri2.ShowDialog();
                Menuler menu1 = new Menuler();
                menu1.Show();

            }
            else
            {
                MessageBox.Show("Giris Başarısız");
            }
            beri.Close();
            
        }

        private void kullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜyeYönetimPaneli beri = new ÜyeYönetimPaneli();
            beri.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uyeOl beri = new uyeOl();
            beri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 beri = new Form3();
            beri.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menuler ekle = new Menuler();
            ekle.Show();
        }
    }
}