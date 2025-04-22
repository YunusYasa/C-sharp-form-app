using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarışması_deneysel_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        int soru = 1;
        int dogru = 0;
        int yanlis = 0;
        private void Form2_Load(object sender, EventArgs e)
        { 
            
            label1.Text = "1";
            richTextBox1.Text = "Atatürkün doğum yılı kaçtır?";

            button1.Text = "1938";
            button2.Text = "1923";
            button3.Text = "1881";
            button4.Text = "1920";

            label3.Text = "1881";

            //İLK SORU
        }
        //ALT TARAF BUTONLAR
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = button1.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
           
            if (label3.Text == label4.Text)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;   
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                MessageBox.Show("Tebrikler deoğru bilidniz şimdi sıra diğer soruda");
            }
            else
            {
                if (label3.Text == button2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;
                }
                if (label3.Text == button3.Text)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }
                if (label3.Text == button4.Text)
                {
                    button4.BackColor = Color.Green;
                }
                else
                {
                    button4.BackColor = Color.Red;
                }

                button1.BackColor = Color.Red;
                MessageBox.Show("Yanlış cevap girdiniz lütfen baştan başlayınız");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text= button2.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (label3.Text == label4.Text)
            {

                button2.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;

                MessageBox.Show("Tebrikler doğru bilidniz şimdi sıra diğer soruda");
            }
            else
            {
                if (label3.Text == button1.Text)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Red;
                }
                if (label3.Text == button3.Text)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }
                if (label3.Text == button4.Text)
                {
                    button4.BackColor = Color.Green;
                }
                else
                {
                    button4.BackColor = Color.Red;
                }
                button2.BackColor = Color.Red;
                MessageBox.Show("Yanlış cevap girdiniz lütfen baştan başlayınız");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = button3.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (label3.Text == label4.Text)
            {

                button3.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                MessageBox.Show("Tebrikler deoğru bilidniz şimdi sıra diğer soruda");
            }
            else
            {
                if (label3.Text == button2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;
                }
                if (label3.Text == button1.Text)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Red;
                }
                if (label3.Text == button4.Text)
                {
                    button4.BackColor = Color.Green;
                }
                else
                {
                    button4.BackColor = Color.Red;
                }
                button3.BackColor = Color.Red;
                MessageBox.Show("Yanlış cevap girdiniz lütfen baştan başlayınız");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = button4.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (label3.Text == label4.Text)
            {

                button4.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                MessageBox.Show("Tebrikler deoğru bilidniz şimdi sıra diğer soruda");
            }
            else
            {
                if (label3.Text == button2.Text)
                {
                    button2.BackColor = Color.Green;
                }
                else
                {
                    button2.BackColor = Color.Red;
                }
                if (label3.Text == button3.Text)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }
                if (label3.Text == button1.Text)
                {
                    button1.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Red;
                }
                button4.BackColor = Color.Red;
                MessageBox.Show("Yanlış cevap girdiniz lütfen baştan başlayınız");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        //BUNDAN SONRASI CEVAPLA BUTONU
        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            soru++;
            label1.Text=soru.ToString();
            
            if (soru == 2)
            {
                richTextBox1.Text = "Dünyanın en büyük yüzölçümüne sahip ülkesi neresidir";
                

                button1.Text = "Hindistan";
                button2.Text = "Çin";
                button3.Text = "Avusturalya";
                button4.Text = "Rusya";

                label3.Text = "Rusya";

                
            }

            if (soru == 3)
            {
                richTextBox1.Text = "Dünyanın en kalabalık ülkesi neresidir";

                button1.Text = "Hindistan";
                button2.Text = "Çin";
                button3.Text = "Avusturalya";
                button4.Text = "Rusya";

                label3.Text = "Çin";
            }
            if (soru == 4)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }



          }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


       
        
    

