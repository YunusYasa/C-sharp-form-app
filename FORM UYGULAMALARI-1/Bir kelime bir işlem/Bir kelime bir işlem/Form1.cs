using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_kelime_bir_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Random = new Random();
        int harfsayac = 0;
        int sayisayac = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            harfsayac++;
            string karakter1, karakter2, karakter3, karakter4, karakter5, karakter6, karakter7, karakter8, karakter9;
            int harfler;
            string[] dizi = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            if (harfsayac == 1)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter1 = dizi[harfler];
                button2.Text = karakter1;
                button2.Visible = true;
            }
            if (harfsayac == 2)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter2 = dizi[harfler];
                button3.Text = karakter2;
                button3.Visible = true;
            }
            if (harfsayac == 3)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter3 = dizi[harfler];
                button4.Text = karakter3;
                button4.Visible = true;
            }
            if (harfsayac == 4)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter4 = dizi[harfler];
                button5.Text = karakter4;
                button5.Visible = true;
            }
            if (harfsayac == 5)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter5 = dizi[harfler];
                button6.Text = karakter5;
                button6.Visible = true;
            }
            if (harfsayac == 6)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter6 = dizi[harfler];
                button7.Text = karakter6;
                button7.Visible = true;
            }
            if (harfsayac == 7)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter7 = dizi[harfler];
                button8.Text = karakter7;
                button8.Visible = true;
            }
            if (harfsayac == 8)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter8 = dizi[harfler];
                button9.Text = karakter8;
                button9.Visible = true;
            }
            if (harfsayac == 9)
            {
                harfler = Random.Next(0, dizi.Length);
                karakter9 = dizi[harfler];
                button10.Text = karakter9;
                button10.Visible = true;
            }  
         
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sayisayac++;
            string deger1, deger2, deger3, deger4, deger5, deger6;
            int deger7;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "50", "60", "75" };
            int sayilar;

            if (sayisayac == 1)
            {
                sayilar = Random.Next(0,dizi2.Length);
                deger1 = dizi2[sayilar];
                button12.Text = deger1;
                button12.Visible = true;
            }
            if (sayisayac == 2)
            {
                sayilar = Random.Next(0, dizi2.Length);
                deger2 = dizi2[sayilar];
                button13.Text = deger2;
                button13.Visible = true;
            }
            if (sayisayac == 3)
            {
                sayilar = Random.Next(0, dizi2.Length);
                deger3 = dizi2[sayilar];
                button14.Text = deger3;
                button14.Visible = true;
            }
            if (sayisayac == 4)
            {
                sayilar = Random.Next(0, dizi2.Length);
                deger4 = dizi2[sayilar];
                button15.Text = deger4;
                button15.Visible = true;
            }
            if (sayisayac == 5)
            {
                sayilar = Random.Next(0, dizi2.Length);
                deger5 = dizi2[sayilar];
                button16.Text = deger5;
                button16.Visible = true;
            }
            if (sayisayac == 6)
            {
                sayilar = Random.Next(0, dizi3.Length);
                deger6 = dizi3[sayilar];
                button17.Text = deger6;
                button17.Visible = true;
            }
            if (sayisayac == 7)
            {

                deger7 = Random.Next(100, 500);
                button19.Text = deger7.ToString();
                button19.Visible = true;
                button18.Visible = true;
            }

        }
    }
}
