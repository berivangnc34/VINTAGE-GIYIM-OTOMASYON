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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox1.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox1.Text+ "','" + textBox2.Text + "','" + yol + "')";
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
    
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            PictureBox yeniItem = new PictureBox();
            yeniItem.Width = 200;
            yeniItem.Height = 160;
            openFileDialog1.ShowDialog();
            try
            {
                string yol = openFileDialog1.FileName;
                pictureBox1.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + yol + "')";
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
            */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox18.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox35.Text + "','" + textBox34.Text + "','" + yol + "')";
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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox1.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox1.Text+ "','" + textBox2.Text + "','" + yol + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox5.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox18.Text + "','" + textBox17.Text + "','" + yol + "')";
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
            }/*
            
            
            
            openFileDialog1.ShowDialog();
            try
            {
                string yol = openFileDialog1.FileName;
                pictureBox1.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + yol + "')";
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
            }*/
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox6.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox7.Text + "','" + textBox6.Text + "','" + yol + "')";
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
        }

        public ImageLayout Stretch { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox4.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox31.Text + "','" + textBox30.Text + "','" + yol + "')";
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox3.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox26.Text + "','" + textBox25.Text + "','" + yol + "')";
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox2.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox19.Text + "','" + textBox36.Text + "','" + yol + "')";
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox12.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox5.Text + "','" + textBox4.Text + "','" + yol + "')";
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox10.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox3.Text + "','" + textBox2.Text + "','" + yol + "')";
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox8.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox16.Text + "','" + textBox15.Text + "','" + yol + "')";
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox15.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox8.Text + "','" + textBox22.Text + "','" + yol + "')";
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox14.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox24.Text + "','" + textBox23.Text + "','" + yol + "')";
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
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox11.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox14.Text + "','" + textBox13.Text + "','" + yol + "')";
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
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox9.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox12.Text + "','" + textBox11.Text + "','" + yol + "')";
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
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox7.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox10.Text + "','" + textBox29.Text + "','" + yol + "')";
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
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox13.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox21.Text + "','" + textBox20.Text + "','" + yol + "')";
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
        }

        private void button18_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
            try
            {
                SqlConnection baglanVeri = sqlBaglan.baglan();
                string yol = openFileDialog1.FileName;
                pictureBox17.ImageLocation = yol;
                string resimEkleme = "INSERT INTO ayakkabilar(ayakkabiNo,ayakkabiFiyat,ayakkabiResim)VALUES('" + textBox33.Text + "','" + textBox32.Text + "','" + yol + "')";
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
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}

