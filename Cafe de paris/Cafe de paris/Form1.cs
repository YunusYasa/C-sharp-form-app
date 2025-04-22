using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_de_paris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaYemek anaYemek = new anaYemek();
            anaYemek.masaolayı2 = masasayi;
            anaYemek.Show();
            this.Hide();
        }
        public string masasayi;
        public string masasayi2;

        private void Form1_Load(object sender, EventArgs e)
        {
            Masa masa = new Masa();
            string a = masasayi;
            label3.Text = a;

           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa();  
            masa.Show();
            this.Hide();
        }

       
    }
}
