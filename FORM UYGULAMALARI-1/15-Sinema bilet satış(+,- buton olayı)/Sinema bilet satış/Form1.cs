using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_bilet_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0,seans2 =0 ,seans3 = 0;
        int seans1ucret = 0, seans2ucret = 0, seans3ucret = 0;
        int kulam, sarıkulam, misirm = 0;
        int kula, sarıkula, misir = 0;





        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";

            if (textBox1.Text.Equals("0"))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            //-------
            if (textBox3.Text.Equals("0"))
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
            //-------
            if (textBox5.Text.Equals("0"))
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
            //BU DA BÜFE - BUTONU ENABLEDİ İÇİN AZ BAK ANALARSIN
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1ucret += 10;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            //10 kişilik salon demek oluyor yani alttaki if 

            if (seans1 == 10)
            {
                button1.Enabled = false;
            }
            if (seans1 >= 0)
            {
                button2.Enabled = true;
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucret -= 10;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            if (seans1 <= 10)
            {
                button1.Enabled = true;
            }
           
          
        }

        

        //BÜFE KISMI KENDİSİ ZORLA BURAYA ATIYOR

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            kulam++;
            kula += 25;
            textBox7.Text = kulam.ToString();
            textBox8.Text = kula.ToString();
            if (kulam == 0)
            {
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            kulam--;
            kula -= 25;
            textBox7.Text = kulam.ToString();
            textBox8.Text = kula.ToString();

            if (kulam == 0)
            {
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
            }
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;

            sarıkulam++;
            sarıkula += 25;
            textBox9.Text = sarıkulam.ToString();
            textBox10.Text = sarıkula.ToString();
            if (sarıkulam == 0)
            {
                button9.Enabled = false;
            }
            else
            {
                button9.Enabled = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            sarıkulam--;
            sarıkula -= 25;
            textBox9.Text = sarıkulam.ToString();
            textBox10.Text = sarıkula.ToString();

            if (sarıkulam == 0)
            {
                button9.Enabled = false;
            }
            else
            {
                button9.Enabled = true;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;

            misir++;
            misirm += 25;
            textBox11.Text = misir.ToString();
            textBox12.Text = misirm.ToString();
            if (misirm == 0)
            {
                button11.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            misir--;
            misirm -= 25;
            textBox11.Text = misir.ToString();
            textBox12.Text = misirm.ToString();

            if (misirm == 0)
            {
                button11.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
            }
        }
//

        private void button4_Click(object sender, EventArgs e)
        {

            seans2++;
            seans2ucret += 10;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2ucret.ToString();

            if (seans2 == 10)
            {
                button4.Enabled = false;
            }
            if (seans2 >= 0)
            {
                button3.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucret -= 10;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2ucret.ToString();
            if (seans2 == 0)
            {
                button3.Enabled = false;
            }
            if (seans2 <= 10)
            {
                button4.Enabled = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ucret += 10;
            textBox6.Text = seans3.ToString();
            textBox5.Text = seans3ucret.ToString();

            if (seans3 == 10)
            {
                button6.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button5.Enabled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucret -= 10;
            textBox6.Text = seans3.ToString();
            textBox5.Text = seans3ucret.ToString();
            if (seans3 == 0)
            {
                button5.Enabled = false;
            }
            if (seans3 <= 10)
            {
                button6.Enabled = true;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            //1,8,10,12
            toplam = Int32.Parse(textBox2.Text) + Int32.Parse(textBox8.Text) + Int32.Parse(textBox10.Text) +
                Int32.Parse(textBox12.Text)+Int32.Parse(textBox3.Text)+  Int32.Parse(textBox5.Text)  ;
            

           label14.Visible = true;
           label15.Visible = true;
           label16.Visible = true;

           label16.Text = toplam.ToString()+"TL";
        }
    }
    
}
