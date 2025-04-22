namespace Random_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            int sayi = rnd.Next(1, 7);
            label1.Text = sayi.ToString();

            int sayi2 = rnd.Next(1, 7);
            label2.Text = sayi2.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}