using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cafe_de_paris
{
    public partial class anaYemek : Form
    {
        Form1 form1;
        public anaYemek()
        {
            InitializeComponent();
        }
        public string masaolayı2;

        public int toplam ;
        string a;
        private void anaYemek_Load(object sender, EventArgs e)
        {
            label20.Text = masaolayı2;
            label1.Text = "0";
            label2.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label15.Text = "0";
            label16.Text = "0";

            if (label2.Text.Equals("0"))
            {
                button6.Enabled = false;
            }
            if (label7.Text.Equals("0"))
            {
                button7.Enabled = false;
            }
            if (label11.Text.Equals("0"))
            {
                button9.Enabled = false;
            }
            if (label15.Text.Equals("0"))
            {
                button11.Enabled = false;
            }

        }
        //HAMBURGERİN ALANI
        int adet,adet2,adet3,adet4 = 0;
        int fiyat,fiyat2,fiyat3,fiyat4 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
           
            if (fiyat > 0)
            {
                button6.Enabled = true;
            }
            
            if (comboBox1.Text == "KLASİK BURGER")
            {
               
                adet++;
                fiyat += 50;
                textBox1.Text=adet.ToString();
                textBox2.Text=fiyat.ToString();
            }
            else if (comboBox1.Text == "ISLAK BURGER")
            {
                
                adet++;
                fiyat += 45;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "CHICKEN BURGER")
            {
                
                adet++;
                fiyat += 40;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "LÜKS BURGER")
            {
                
                adet++;
                fiyat += 80;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "CHEESE BURGER")
            {
                
                adet++;
                fiyat += 60;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "KLASİK BURGER")
            {
                adet--;
                fiyat -= 50;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "ISLAK BURGER")
            {
                
                adet--;
                fiyat -= 45;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "CHICKEN BURGER")
            {
                
                adet--;
                fiyat -= 40;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "LÜKS BURGER")
            {
                
                adet--;
                fiyat -= 80;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            else if (comboBox1.Text == "CHEESE BURGER")
            {
                
                adet--;
                fiyat -= 60;
                textBox1.Text = adet.ToString();
                textBox2.Text = fiyat.ToString();
            }
            if (fiyat == 0)
            {
                button6.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            adet = 0;
            fiyat = 0;

            label1.Text = adet.ToString();
            label2.Text = fiyat.ToString();
        }
        //BURDA BİTİYOR
        //CAJUN TAVUK
        private void button8_Click(object sender, EventArgs e)
        {
            adet2++;
            fiyat2 += 65;

            textBox3.Text = adet2.ToString();
            textBox4.Text = fiyat2.ToString();

            if (adet2 > 0)
            {
                button7.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.masasayi = masaolayı2;
            form.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner= this;
            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adet2--;
            fiyat2 -= 65;

            textBox3.Text = adet2.ToString();
            textBox4.Text = fiyat2.ToString();

            if (fiyat2 == 0)
            {
                button7.Enabled = false;
            }
        }
        //CAJUN BİTİŞ
        //KÖRİLİ TAVUK
        private void button10_Click(object sender, EventArgs e)
        {
            adet3++;
            fiyat3 += 60;

            label11.Text=adet3.ToString();
            label12.Text=fiyat3.ToString();

            if (adet3 > 0)
            {
                button9.Enabled = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            adet3--;
            fiyat3 -= 60;

            label11.Text = adet3.ToString();
            label12.Text = fiyat3.ToString();

            if (adet3 == 0)
            {
                button9.Enabled = false;
            }

        }
        //KÖRİ BİTİŞ
        private void button12_Click(object sender, EventArgs e)
        {
            adet4++;
            fiyat4 += 60;

            label15.Text = adet4.ToString();
            label16.Text = fiyat4.ToString();

            if (adet4 > 0)
            {
             button11.Enabled= true;
            }


        }
        private void button11_Click(object sender, EventArgs e)
        {
            adet4--;
            fiyat4 -= 60;

            label15.Text = adet4.ToString();
            label16.Text = fiyat4.ToString();

            if (adet4 == 0)
            {
                button11.Enabled = false;
            }
        }
        //EKLE KISMI
        private void button13_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();
            toplam = Int32.Parse(label2.Text) + Int32.Parse(label8.Text) +
                Int32.Parse(label12.Text) + Int32.Parse(label16.Text);

            label18.Text= toplam.ToString();

            if(!textBox1.Text.Equals(" "))
            {
             listBox1.Items.Add(textBox2.Text + " tane " + comboBox1.Text);
                 
            }
            if (!textBox4.Text.Equals("0"))
            {
             listBox1.Items.Add(textBox4.Text + " tane cajun tavuk");
               
               
            }
            if (!label11.Text.Equals("0"))
            {
             listBox1.Items.Add(label11.Text + " tane körili tavuk");
               

            }
            if (!label15.Text.Equals("0"))
            {
             listBox1.Items.Add(label15.Text + " tane kekikli tavuk");
               
            }
          
        }



    }
}
