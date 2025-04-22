using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Span_zaman_farkı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ilk = dateTimePicker1.Value;
            DateTime ikinci = dateTimePicker2.Value;

            System.TimeSpan zaman;
            zaman =ikinci.Subtract(ilk);//Bu ikinci - iki demek oluyor aslında...
            int gün = Convert.ToInt32(zaman.TotalDays);//.total olay burda !!!!
            int saat = Convert.ToInt32(zaman.TotalHours);
            int dk = Convert.ToInt32(zaman.TotalMinutes);

            label2.Text = gün.ToString();
            label4.Text = saat.ToString();
            label6.Text = dk.ToString();

        }
    }
}
