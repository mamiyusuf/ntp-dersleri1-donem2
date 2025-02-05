namespace iki_sayı_toplayan_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int sonuc;

            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);

            sonuc = sayi1 + sayi2;
            txtsonuc.Text = sonuc.ToString();
        }
    }
}