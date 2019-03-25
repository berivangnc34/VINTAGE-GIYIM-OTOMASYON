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

namespace WindowsFormsApplication3
{
    public partial class Menuler : DevExpress.XtraEditors.XtraForm
    {
        public Menuler()
        {
            InitializeComponent();
        }

        public string resimayakkabi { get; set; }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 kiyafetler = new Form2();
            kiyafetler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox yeniItem = new PictureBox();
            yeniItem.Width = 200;
            yeniItem.Height = 160;
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 ayakkabiekle = new Form3();
            ayakkabiekle.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 takilar = new Form4();
            takilar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guncelleForm FRM = new guncelleForm();
            FRM.Show();
        }
    }
}