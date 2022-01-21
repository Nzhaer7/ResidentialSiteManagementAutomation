using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteYonetimOtomasyonu
{
    public partial class Personel_Kayıt_ol : Form
    {
        public Personel_Kayıt_ol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Personel_Ortak_Kaydol personel_Ortak_Kaydol = new Personel_Ortak_Kaydol();
            personel_Ortak_Kaydol.Show();
            this.Hide();
        }
    }
}
