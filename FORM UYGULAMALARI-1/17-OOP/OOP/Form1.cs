using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();

            oto.marka = "Renault";
            oto.model = "Toros";
            oto.modelyili = 1982;
            oto.renk = "Yeşil";
            oto.vitestipi = "Manuel";

            string marka = oto.marka;

            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.modelyili.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();
        }
    }
}
