using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplam1 = 0;
        int toplam2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled= false;
            button2.Enabled = true;

            int a = rastgele.Next(1,7);
            label2.Text = a.ToString();
            int b = rastgele.Next(1, 7);
            label4.Text = b.ToString();

            toplam1 += a + b;
            label15.Text = toplam1.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //enabled kullanılabilirlik demek işte la
            button2.Enabled = false;
            button1.Enabled = true;
            //.Next olayı range olayıyla aynı
            int c = rastgele.Next(1, 7);
            label11.Text = c.ToString();
            int d = rastgele.Next(1, 7);
            label9.Text = d.ToString();

            toplam2 += c + d;
            label16.Text = toplam2.ToString();

            if (toplam1 > 50 && toplam1 > toplam2)
            {
                label17.Text = "1.Oyunucu Kazandı";
                button2.Enabled = false;
                button1.Enabled = false;
            }
            else if (toplam2 > 50 && toplam2 > toplam2)
            {
                label17.Text = "2.Oyunucu Kazandı";
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           button2.Enabled = false;
        }
    }
}
