using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_de_paris
{
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }

        private void form()
        {
            Form1 form = new Form1();
            form.masasayi = label4.Text;
            form.Show();
            this.Hide();
            
        }
     
        private void button22_Click(object sender, EventArgs e)
        {
            form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "40"; button22.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "41"; button22.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "42"; button22.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "43"; button22.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "44"; button22.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "45"; button22.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "46"; button22.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = "47"; button22.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = "48"; button22.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = "49"; button22.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text = "50"; button22.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label4.Text = "51"; button22.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label4.Text = "52"; button22.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label4.Text = "53"; button22.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label4.Text = "54"; button22.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label4.Text = "55"; button22.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label4.Text = "56"; button22.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label4.Text = "57";
            button22.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label4.Text = "58";
            button22.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button22.Enabled = true;
            label4.Text = "59";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label4.Text = "60";
            button22.Enabled = true;
        }

        private void Masa_Load(object sender, EventArgs e)
        {
            button22.Enabled = false;
        }
    }
}
