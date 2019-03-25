using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public SqlConnection baglanVeri = sqlBaglan.baglan();
        private void button1_Click(object sender, EventArgs e)
        {   SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {
                
                string yol = openFileDialog1.FileName;
                pictureBox1.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox1.Text +"','"+ yol+"')";
                SqlCommand komut = new SqlCommand(resimEkleme,baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }


                
            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox2.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox2.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox3.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox3.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox4.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox4.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox5.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox5.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox6.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox6.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox7.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox7.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarısız");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox8.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox8.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox9.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox9.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {
                
                string yol = openFileDialog1.FileName;
                pictureBox11.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox11.Text +"','"+ yol+"')";
                SqlCommand komut = new SqlCommand(resimEkleme,baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }


                
            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox12.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox12.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = sqlBaglan.baglan();
            //pcbox1----
            SqlCommand komut = new SqlCommand("select taki_id,resim,fiyat from taki_tbl", baglanti);
            komut.ExecuteNonQuery();
            SqlDataReader resimOku=komut.ExecuteReader();

          
           while(resimOku.Read())
	        {
                switch (resimOku["taki_id"].ToString())
                {

                    case "1":
                         pictureBox1.ImageLocation=resimOku["resim"].ToString();
                         textBox1.Text = resimOku["fiyat"].ToString();
                         break;
                    case "2":
                         pictureBox2.ImageLocation = resimOku["resim"].ToString();
                         textBox2.Text = resimOku["fiyat"].ToString();
                         break;
                    case "3":
                         pictureBox3.ImageLocation = resimOku["resim"].ToString();
                         textBox3.Text = resimOku["fiyat"].ToString();
                         break;
                    case "4":
                         pictureBox4.ImageLocation = resimOku["resim"].ToString();
                         textBox4.Text = resimOku["fiyat"].ToString();
                         break;
                    case "5":
                         pictureBox5.ImageLocation = resimOku["resim"].ToString();
                         textBox5.Text = resimOku["fiyat"].ToString();
                         break;
                    case "6":
                         pictureBox6.ImageLocation = resimOku["resim"].ToString();
                         textBox6.Text = resimOku["fiyat"].ToString();
                         break;
                    case "7":
                         pictureBox7.ImageLocation = resimOku["resim"].ToString();
                         textBox7.Text = resimOku["fiyat"].ToString();
                         break;
                    case "8":
                         pictureBox8.ImageLocation = resimOku["resim"].ToString();
                         textBox8.Text = resimOku["fiyat"].ToString();
                         break;
                    case "9":
                         pictureBox9.ImageLocation = resimOku["resim"].ToString();
                         textBox9.Text = resimOku["fiyat"].ToString();
                         break;
                    case "10":
                         pictureBox10.ImageLocation = resimOku["resim"].ToString();
                         textBox10.Text = resimOku["fiyat"].ToString();
                         break;
                    case "11":
                         pictureBox11.ImageLocation = resimOku["resim"].ToString();
                         textBox11.Text = resimOku["fiyat"].ToString();
                         break;
                    case "12":
                         pictureBox12.ImageLocation = resimOku["resim"].ToString();
                         textBox12.Text = resimOku["fiyat"].ToString();
                         break;

                       

                    default:
                        break;
                }

	        }
            resimOku.Close();

           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection baglanVeri = sqlBaglan.baglan();
            openFileDialog1.ShowDialog();
            try
            {

                string yol = openFileDialog1.FileName;
                pictureBox9.ImageLocation = yol;
                string resimEkleme = "INSERT INTO taki_tbl(fiyat,resim)VALUES('" + textBox9.Text + "','" + yol + "')";
                SqlCommand komut = new SqlCommand(resimEkleme, baglanVeri);
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc != 1)
                {
                    MessageBox.Show("Kayıt Başarılı");

                }



            }

            catch (Exception er)
            {

                MessageBox.Show("hata", er.Message);
            }
            baglanVeri.Close();
        }
    }
}
    
