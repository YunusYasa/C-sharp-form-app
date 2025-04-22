using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Login_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.GreenYellow;

            panel2.BackColor = Color.GreenYellow;
            textBox2.ForeColor = Color.White;

            panel3.BackColor = Color.GreenYellow;
            textBox3.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.GreenYellow;

            panel1.BackColor = Color.GreenYellow;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.GreenYellow;
            textBox3.ForeColor = Color.White;
        }


        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.GreenYellow;

            panel2.BackColor = Color.GreenYellow;
            textBox2.ForeColor = Color.White;

            panel1.BackColor = Color.GreenYellow;
            textBox1.ForeColor = Color.White;
        }

        Form2 form2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            form2.Left += 10;

            if (form2.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;
                form2.TopMost = true;
                timer2.Start();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            form2.Left -= 10;

            if (form2.Left <=620)
            {
                timer2.Stop();
            }
        }
    }
}
