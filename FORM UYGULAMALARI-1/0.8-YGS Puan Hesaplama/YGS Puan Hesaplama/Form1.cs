using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGS_Puan_Hesaplama
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1,vize2,final;
            double sonuc;

            vize1    = Convert.ToDouble(textBox1.Text);
            vize2 = Convert.ToDouble(textBox2.Text);
            final       = Convert.ToDouble(textBox3.Text);
            
            sonuc = vize1*0.2 + vize2*0.2 + final*0.6;

            label3.Text = sonuc.ToString();

            
         
        }
    }
}
