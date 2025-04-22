using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renk_değiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult pencere;
            pencere = colorDialog1.ShowDialog();

            if (pencere == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = richTextBox1.SelectionColor;

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog.Color != richTextBox1.SelectionColor) ;
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            label1.ForeColor = colorDialog.Color;
        }
    }
}
