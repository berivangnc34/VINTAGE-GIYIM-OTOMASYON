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
    public partial class uyeOl : Form
    {
        public uyeOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection beri = sqlBaglan.baglan();
            string komut = "INSERT INTO kullaniciGiris (kullaniciAdi,sifre,AdıSoyadı,Telefon,Eposta,Sehir,Cinsiyet) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7)";
            SqlCommand beri1 = new SqlCommand(komut, beri);

            beri1.Parameters.AddWithValue("@P1", textBox1.Text);
            beri1.Parameters.AddWithValue("@P2", textBox2.Text);
            beri1.Parameters.AddWithValue("@P3", adsyadtex.Text);
            beri1.Parameters.AddWithValue("@P4", telefontex.Text);
            beri1.Parameters.AddWithValue("@P5", epostatex.Text);
            beri1.Parameters.AddWithValue("@P6", sehrtex.Text);
            beri1.Parameters.AddWithValue("@P7", cinsiyet);
            beri1.ExecuteNonQuery();
            beri.Close();
        }
        string cinsiyet;
        private void uyeOl_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cinsiyet = "ERKEK";
            }
            if (checkBox2.Checked)
            {
                cinsiyet = "KADIN";
            }
        }
    }
}
