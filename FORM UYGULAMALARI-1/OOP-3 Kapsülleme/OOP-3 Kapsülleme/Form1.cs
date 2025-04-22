using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3_Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.Semt = textBox1.Text;
            c.Odasayisi = Convert.ToInt32(textBox2.Text);
            c.Katno = Convert.ToInt32(textBox3.Text);
            c.Alan = Convert.ToInt32(textBox4.Text);

            ListViewItem kayit = new ListViewItem();
            kayit.Text = c.Semt;
            kayit.SubItems.Add(c.Odasayisi.ToString()); 
            kayit.SubItems.Add(c.Katno.ToString());
            kayit.SubItems.Add(c.Alan.ToString());

            listView1.Items.Add(kayit);

        }
    }
}
