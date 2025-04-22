using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_araç_oluşturma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Label[] labels = new Label[10];

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "label" + i.ToString();
                this.Controls.Add(labels[i]);
                labels[i].BackColor = Color.White;
                labels[i].Top = i * 50;
                labels[i].Left = 50;
            }
        }
    }
}
