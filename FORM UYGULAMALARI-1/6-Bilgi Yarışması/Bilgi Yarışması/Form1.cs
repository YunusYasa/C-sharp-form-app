using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            soruno++;
            label2.Text = soruno.ToString();
            

            if (soruno == 1)
            {
                
                richTextBox1.Text = "Mustafa Kemal Paşa kaç yılında doğmuştur?";

                button1.Text = "1938";
                button2.Text = "1923";
                button3.Text = "1918";
                button4.Text = "1920";

                label3.Text = "1918";
                

                

            }

            if (soruno == 2)
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                richTextBox1.Text = "Bakırın simgesi nedir?";

                button1.Text = "Ag";
                button2.Text = "B";
                button3.Text = "Br";
                button4.Text = "Cu";

                if (label3 == label4)
                {

                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Green;


                }
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label4.Text =button2.Text;

            if (label3.Text == label4.Text)
            {

                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;

            }
            else
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = button3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = button1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = button4.Text;
        }
    }
}
