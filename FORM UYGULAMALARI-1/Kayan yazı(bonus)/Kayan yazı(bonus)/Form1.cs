using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayan_yazı_bonus_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Durak isimleri";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "M1A Yenikapı-Atatürk Havalimanı Metro Hattı")
            {
                textBox2.Text = "Atatürk Havalimanı,DTM-İstanbul Fuar Merkezi,Yenibosna,Ataköy-Şirinevler,Bahçelievler,Bakırköy-İncirli,Zeytinburnu,Merter,Davutpaşa-YTÜ,Terazidere,Otogar,Kocatepe,Sağmalcılar,Bayrampaşa-Maltepe,Topkapı-Ulubatlı,Emniyet-Fatih,Aksaray,Yenikapı";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Substring(1) + textBox2.Text.Substring(0,1);
        }
    }
}
