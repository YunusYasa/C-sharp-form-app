using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme__1_TaBase64_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anametin = textBox1.Text;
            byte[] veridizi = ASCIIEncoding.ASCII.GetBytes(anametin);
            string sifrelimetin = Convert.ToBase64String(veridizi);
            textBox2.Text= sifrelimetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifrelimetin = textBox2.Text;
            byte[] cveridizi = Convert.FromBase64String(sifrelimetin);
            string anametin = ASCIIEncoding.ASCII.GetString(cveridizi);
            textBox1.Text= anametin;
        }
    }
}
