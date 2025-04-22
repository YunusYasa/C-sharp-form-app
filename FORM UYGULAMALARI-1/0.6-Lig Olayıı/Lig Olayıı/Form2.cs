using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lig_Olayıı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        Random random = new Random();
        int fb = 0;
        int gs = 0;
        int bjk = 0;
        int ts = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int a = random.Next(0,5);
            int b = random.Next(0,5);
            int c = random.Next(0,5);
            int d = random.Next(0,5);
            label4.Text=a.ToString();//fener
            label3.Text=b.ToString();//galata
            label7.Text=c.ToString();//ts
            label8.Text=d.ToString();//beşik

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label3.Text))
            {
                fb += 3;
                label23.Text=fb.ToString();
            }
            else if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label3.Text))
            {
                fb += 1;
                gs += 1;
                label23.Text = fb.ToString();
                label22.Text = gs.ToString();

            }
            else
            {
                gs += 3;
                label22.Text = gs.ToString();

            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                ts += 3;
                label19.Text = ts.ToString();

            }
            else if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                ts += 1;
                bjk += 1;
                label19.Text = gs.ToString();
                label21.Text = gs.ToString();

            }
            else
            {
                bjk += 3;
                label21.Text = gs.ToString();

            }
        }
    }
}
