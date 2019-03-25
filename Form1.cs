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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string kyafet=" ";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sqlBaglan.baglan();

            SqlCommand komut = new SqlCommand();
           

            //ekleme komutu
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO malzeme(kiyafet_adi,modeli,fiyati)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            komut.ExecuteNonQuery();


            this.malzemeTableAdapter.Fill(this.berisqlDataSet.malzeme);
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'berisqlDataSet.malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter.Fill(this.berisqlDataSet.malzeme);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int beri = dataGridView1.SelectedCells[0].RowIndex;
            kyafet = dataGridView1.Rows[beri].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kyafet != " " && kyafet != null) { 
            SqlConnection beri = sqlBaglan.baglan();
            string komut = "DELETE FROM malzeme where kiyafet_adi=@p1";
            SqlCommand beri1 = new SqlCommand(komut, beri);
            beri1.Parameters.Add("@p1", kyafet);
            beri1.ExecuteNonQuery();
            beri.Close();
            kyafet = " ";
            this.malzemeTableAdapter.Fill(this.berisqlDataSet.malzeme);
            }
            else
            {
                MessageBox.Show("seçim yapınız");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelleForm beri = new guncelleForm();
            beri.ShowDialog();
            this.malzemeTableAdapter.Fill(this.berisqlDataSet.malzeme);

        }
    }
}
