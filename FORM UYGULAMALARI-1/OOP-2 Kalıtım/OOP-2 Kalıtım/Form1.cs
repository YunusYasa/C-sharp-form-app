using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2_Kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            İnsan i =new İnsan();

            i.ad = "Yunus";
            i.soyad = "Yaşa";
            i.kilo = "50";
            i.yas = "24";
            i.boy = "173";

            label8.Text = i.ad;
            label9.Text = i.soyad;
            label10.Text = i.yas;
            label11.Text = i.boy;
            label12.Text = i.kilo;
            
            Personel p = new Personel();

            p.departman = "Yazılım";
            p.yer = "Konya";

            label13.Text = p.departman;
            label14.Text = p.yer;
            //OLAY BURDA KALITIMLA PERSONEL CLASSINDA OLAMAYN ÖZ. İNSAN CALASSINDAN ALIP KULLANIYORUZ.
            p.ad = "Yusuf";
            p.soyad = "Yaşa";
            p.yas = "14";
            p.boy = "170";

            label19.Text = p.ad;
            label20.Text = p.soyad;
            label21.Text = p.yas;
            label22.Text = p.boy;
            
        }
    }
}
