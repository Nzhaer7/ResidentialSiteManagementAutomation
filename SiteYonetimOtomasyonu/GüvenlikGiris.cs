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
    public partial class GüvenlikGiris : Form
    {
        public GüvenlikGiris()
        {
            InitializeComponent();
        }

        private void GüvenlikGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Güvenlik_anasayfa güvenlik_Anasayfa = new Güvenlik_anasayfa();
            güvenlik_Anasayfa.Show();
            this.Hide();
            

        }
    }
}
