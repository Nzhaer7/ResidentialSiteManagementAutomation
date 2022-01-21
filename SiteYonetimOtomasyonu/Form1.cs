namespace SiteYonetimOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Kiraci kiraci = new Kiraci();
            kiraci.Show();
            this.Hide ();
        }
    }
}