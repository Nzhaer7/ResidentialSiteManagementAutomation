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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GüvenlikGiris güvenlikGiris = new GüvenlikGiris();
            güvenlikGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UstaGiris ustaGiris = new UstaGiris();  
            ustaGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TemizlikciGiris temizlikciGiris = new TemizlikciGiris();    
            temizlikciGiris.Show();
            this.Hide();
        }
    }
}
