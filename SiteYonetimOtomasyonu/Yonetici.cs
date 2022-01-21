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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Yonetici_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yönetici_anasayfa_arayüz yönetici_Anasayfa_Arayüz = new Yönetici_anasayfa_arayüz();
            yönetici_Anasayfa_Arayüz.Show();
            this.Hide();
        }
    }
}
