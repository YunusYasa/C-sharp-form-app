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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LABEL
            Label label = new Label();
            Point lblkonum = new Point(50,50);
            label.Location = lblkonum;
            label.Name = "label1";
            label.Text = "labell1";
            label.BackColor = Color.Red;
            this.Controls.Add(label);

            //
            TextBox txt = new TextBox();
            Point txtkonum = new Point(50, 50);
            txt.Location = txtkonum;
            label.Name = "txt1"; 
            groupBox1.Controls.Add(txt);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.Show(); this.Hide();
        }
    }
}
