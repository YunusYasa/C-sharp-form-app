﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yön_tuşları_kullanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x <600)
            {
                x += 15;
            }
            if (e.KeyCode == Keys.Left && x > 0)
            {
                x -= 15;
            }
            if (e.KeyCode == Keys.Up && y > 0)
            {
                y -= 15;
            }
            if (e.KeyCode == Keys.Down && y < 400)
            {
                y += 15;
            }
            pictureBox1.Location = new Point(x, y);


        }
    }
}
