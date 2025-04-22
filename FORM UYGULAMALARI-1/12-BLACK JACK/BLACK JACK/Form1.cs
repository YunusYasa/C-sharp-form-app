using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLACK_JACK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Random = new Random();
        int sayac = 0;
        int sayac2 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;


            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = Random.Next(1, 11);
                a2 = Random.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = Random.Next(1, 11);
                label3.Text = a3.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = Random.Next(1, 11);
                label4.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            sayac2++;


            if (sayac2 == 1)
            {
                int a1, a2, toplam;
                a1 = Random.Next(1, 11);
                a2 = Random.Next(1, 11);
                toplam = a1 + a2;

                label5.Text = a1.ToString();
                label6.Text = a2.ToString();
                label11.Text = toplam.ToString();
            }
            if (sayac2 == 2)
            {
                int a3, toplam;
                a3 = Random.Next(1, 11);
                label7.Text = a3.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label11.Text = toplam.ToString();
            }
            if (sayac2 == 3)
            {
                int a4, toplam;
                a4 = Random.Next(1, 11);
                label8.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label11.Text = toplam.ToString();

            }
             */

            int b1,b2,toplam;
            b1=Random.Next(1, 11);
            b2 = Random.Next(1, 11);
            toplam=b1 + b2;

            label5.Text =b1.ToString();
            label6.Text =b2.ToString();
            label11.Text =toplam.ToString();

            if (toplam < 16)
            {
                int b3;
                b3 = Random.Next(1, 11);
                label7.Text =b3.ToString();

                toplam += b3;
                label11.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4;
                b4=Random.Next(1, 11);
                label8.Text =b4.ToString();

                toplam += b4;
                label11.Text=toplam.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
