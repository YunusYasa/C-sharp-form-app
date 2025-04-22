using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Grafik_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Öğrenci Notları");

            this.chart1.Series["Notlar"].Points.AddXY("Yunus", 75);
            this.chart1.Series["Notlar"].Points.AddXY("Baran", 95);
            this.chart1.Series["Notlar"].Points.AddXY("Mustafa", 50);
            this.chart1.Series["Notlar"].Points.AddXY("Yusuf", 100);
            this.chart1.Series["Notlar"].Points.AddXY("Kutay", 80);
            this.chart1.Series["Notlar"].Points.AddXY("Hayrettin", 30);
            this.chart1.Series["Notlar"].Points.AddXY("Abuzer", 42);

        }
    }
}
