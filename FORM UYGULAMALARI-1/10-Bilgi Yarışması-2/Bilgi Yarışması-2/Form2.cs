using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilgi_Yarışması_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=CsharpIcin;Integrated Security=True;Encrypt=False");
        int sayac = 0;
        int puan = 0;
        int sayi = 0;
        private void btnbasla_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            

            btnbasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnbasla.Text = "Sonraki";
            sayac++;
            label2.Text = sayac.ToString();

            if (sayac == 1)
            {              
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Sorular1 order by NEWID()", baglanti);
                SqlDataReader oku = cmd.ExecuteReader();


                while (oku.Read())
                {
                    textBox1.Text = (oku["Soru"].ToString());
                    button1.Text = (oku["A"].ToString());
                    button2.Text = (oku["B"].ToString());
                    button3.Text = (oku["C"].ToString());
                    button4.Text = (oku["D"].ToString());
                    lbldogru.Text = (oku["Dogru"].ToString());
                }
                baglanti.Close();
            }
            if (sayac == 2)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Sorular2 order by NEWID()", baglanti);
                SqlDataReader oku = cmd.ExecuteReader();


                while (oku.Read())
                {
                    textBox1.Text = (oku["Soru"].ToString());
                    button1.Text = (oku["A"].ToString());
                    button2.Text = (oku["B"].ToString());
                    button3.Text = (oku["C"].ToString());
                    button4.Text = (oku["D"].ToString());
                    lbldogru.Text = (oku["Doğru"].ToString());
                }
                baglanti.Close();
            }
            if (sayac == 3)
            {
                btnbasla.Text = "Oyunu bitti";
                btnbasla.Enabled = false;
                

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Sorular3 order by NEWID()", baglanti);
                SqlDataReader oku = cmd.ExecuteReader();


                while (oku.Read())
                {
                    textBox1.Text = (oku["Soru"].ToString());
                    button1.Text = (oku["A"].ToString());
                    button2.Text = (oku["B"].ToString());
                    button3.Text = (oku["C"].ToString());
                    button4.Text = (oku["D"].ToString());
                    lbldogru.Text = (oku["Doğru"].ToString());
                }
                baglanti.Close();
            }
            if (sayac == 4)
            {
                textBox1.Clear();
                
                btnbasla.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = sayac.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button1.Text == lbldogru.Text)
            {
                puan += 10;
                label4.Text = puan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (button2.Text == lbldogru.Text)
            {
                puan += 10;
                label4.Text = puan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (button3.Text == lbldogru.Text)
            {
                puan += 10;
                label4.Text = puan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (button4.Text == lbldogru.Text)
            {
                puan += 10;
                label4.Text = puan.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progress bar burda tam tanımlı değil
            progressBar1.Value +=10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
               
            }
            int sayi =Convert.ToInt32(label7.Text);
            sayi++;
            label7.Text = sayi.ToString();

            int ileri_en = label5.Width;
            int bar_en = label3.Width;

            int bitis = label3.Right;

            label5.Left += 10;
             
        }

     
    }
}
