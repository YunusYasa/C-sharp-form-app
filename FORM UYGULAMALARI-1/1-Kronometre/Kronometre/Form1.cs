using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        int saat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(label1.Text);
                sayi++;

                label1.Text = sayi.ToString();
            if (sayi == 59)
            {
                label1.Text = "0";

                dakika++;


                label2.Text = dakika.ToString();
                if (dakika == 59)
                {
                    dakika = 0;
                    label2.Text = "0";


                    saat++;

                    label3.Text = saat.ToString();
                    

                }
            }

            

         

        }
    }
}
