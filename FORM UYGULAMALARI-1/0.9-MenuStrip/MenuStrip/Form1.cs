﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esaretiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Aile her şeydir";
        }

        private void paunVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = toolStripComboBox2.Text;
        }
    }
}
