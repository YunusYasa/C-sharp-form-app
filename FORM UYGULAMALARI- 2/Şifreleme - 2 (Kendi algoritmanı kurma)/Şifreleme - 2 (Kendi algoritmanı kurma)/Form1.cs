﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme___2__Kendi_algoritmanı_kurma_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri = textBox1.Text;
            char[] karakterler = veri.ToCharArray();
            foreach (char i in karakterler)
            {
                textBox2.Text += Convert.ToChar(i + 3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cöz = "";
            cöz = textBox2.Text;
            char[] chr = cöz.ToCharArray();
            foreach (char i in chr)
            {
                textBox1.Text += Convert.ToChar(i - 3);
            }
        }
    }
}
