using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class ÜyeYönetimPaneli : Form
    {
        public ÜyeYönetimPaneli()
        {
            InitializeComponent();
        }

        private void ÜyeYönetimPaneli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'berisqlDataSet2.kullaniciGiris' table. You can move, or remove it, as needed.
            this.kullaniciGirisTableAdapter.Fill(this.berisqlDataSet2.kullaniciGiris);

        }
    }
}
