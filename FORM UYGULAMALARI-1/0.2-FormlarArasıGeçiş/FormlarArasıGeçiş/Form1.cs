namespace FormlarArasıGeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "1234")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ !");
            }
        }
    }
}