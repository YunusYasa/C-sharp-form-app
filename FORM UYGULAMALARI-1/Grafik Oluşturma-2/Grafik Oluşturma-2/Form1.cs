using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik_Oluşturma_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            //ÇİZGİ
            Pen kalem = new Pen(System.Drawing.Color.Red, 3);
            grafiknesne.DrawLine(kalem, 50,50,50,200);

            //KARE(BOŞ)
            Pen kalem2 = new Pen(System.Drawing.Color.Blue, 3);
            grafiknesne.DrawRectangle(kalem2 ,100,100,100,100);

            //YAZI
            Font yazıstili = new Font("Segoe Print", 15, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Red);
            grafiknesne.DrawString("Deneme la deneme",yazıstili, brush, 50, 50);

            //İÇİ DOLU DAİRE (ELİPS)
            Brush brush2 = new SolidBrush(Color.Yellow);
            grafiknesne.FillEllipse(brush2, 225, 100, 100, 100);

            //MATEMATİK LA 
            Pen kalem3 = new Pen(System.Drawing.Color.DarkViolet, 3);
            grafiknesne.DrawArc(kalem3, 350, 50, 100, 100, 90, 270);
            //350,50,100,100 normal değerler 90 bölgesini tanımlar sağ üst sol alt gibi 
            //270 yazan kıısm derecedir 90 da daha az çizer 360 fulkl çizer.
        }
    }
}
