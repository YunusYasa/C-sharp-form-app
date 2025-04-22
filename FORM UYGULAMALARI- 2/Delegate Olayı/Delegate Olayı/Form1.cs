using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Olayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void islemler(int i1, int i2);
            
        void topla(int a1, int a2)
        {
            int toplam = a1 + a2;
            listBox1.Items.Add(toplam);
        }
        void cikarma(int b1, int b2)
        {
            listBox1.Items.Add(b1 - b2);
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            islemler islemler = new islemler(topla);
            islemler += cikarma;
            islemler(10, 2);
        }
    }
}
