using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Chart_Geo_Map_İle_Dünya_Haritası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap g = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> d = new Dictionary<string, double>();
            d["TR"] = 100;
            d["RU"] = 10;
            d["FR"] = 150;
            g.HeatMap = d;
            g.Source = $"{Application.StartupPath}\\XMLFile1.xml";
            this.Controls.Add(g);
            g.Dock = DockStyle.Fill;
           

        }
    }
}
