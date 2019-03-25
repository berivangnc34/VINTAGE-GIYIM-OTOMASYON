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
    public partial class guncelleForm : Form
    {
        public guncelleForm()
        {
            InitializeComponent();
        }
        public string kyafet;
        public string model;
        public string fiyat;
        private void guncelleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'berisqlDataSet1.malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter.Fill(this.berisqlDataSet1.malzeme);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int beri = dataGridView1.SelectedCells[0].RowIndex;
            kyafet = dataGridView1.Rows[beri].Cells[0].Value.ToString();
            model = dataGridView1.Rows[beri].Cells[1].Value.ToString();
            fiyat = dataGridView1.Rows[beri].Cells[2].Value.ToString();
            textBox1.Text = kyafet;
            textBox2.Text = model;
            textBox3.Text = fiyat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection beri = sqlBaglan.baglan();
            string komut = "UPDATE malzeme set kiyafet_adi=@p1,modeli=@p2,fiyati=@p3 where kiyafet_adi=@p4";
            SqlCommand beri1 = new SqlCommand(komut, beri);
            beri1.Parameters.AddWithValue("@p1", textBox1.Text);
            beri1.Parameters.AddWithValue("@p2", textBox2.Text);
            beri1.Parameters.AddWithValue("@p3", textBox3.Text);
            beri1.Parameters.AddWithValue("@p4", kyafet);
            beri1.ExecuteNonQuery();
            this.malzemeTableAdapter.Fill(this.berisqlDataSet1.malzeme);
            beri.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection beri = sqlBaglan.baglan();
            string komut = "delete  from malzeme   where kiyafet_adi=@p4";
            SqlCommand beri1 = new SqlCommand(komut, beri);
           
            beri1.Parameters.AddWithValue("@p4", kyafet);
            beri1.ExecuteNonQuery();
            this.malzemeTableAdapter.Fill(this.berisqlDataSet1.malzeme);
            beri.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
