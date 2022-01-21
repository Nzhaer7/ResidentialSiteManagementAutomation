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
    public partial class Tamam : Form
    {
        public Tamam()
        {
            InitializeComponent();
        }

        private void Tamam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
