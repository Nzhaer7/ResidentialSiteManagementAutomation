﻿using System;
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
    public partial class TemizlikciGiris : Form
    {
        public TemizlikciGiris()
        {
            InitializeComponent();
        }

        private void TemizlikciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemizlikciArayuz temizlikciArayuz = new TemizlikciArayuz();
            temizlikciArayuz.Show();
            this.Hide();
        }
    }
}
