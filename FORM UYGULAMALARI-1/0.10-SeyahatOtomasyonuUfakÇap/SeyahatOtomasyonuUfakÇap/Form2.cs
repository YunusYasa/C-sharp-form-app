using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatOtomasyonuUfakÇap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("1");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            button6.Enabled= false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text=" ";
            comboBox2.Text=" ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("2");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button2.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("3");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button7.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("4");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button3.Enabled = false;
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("5");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button8.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("6");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button4.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("7");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button9.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("8");
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            button5.Enabled = false;

            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }
    }
}
