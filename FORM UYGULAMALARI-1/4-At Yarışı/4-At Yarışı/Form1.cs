using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a1s, a2s, a3s;
        Random rastgele = new Random();
         
        


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bir_at_en = pictureBox1.Width;
            int iki_at_en = pictureBox2.Width;
            int uc_at_en  = pictureBox3.Width;
            
            int bitis = label6.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left+ 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "Bir Numaralı at yarışı önde götürüyor...";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "İki Numaralı at yarışı önde götürüyor...";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label7.Text = "Üç Numaralı at yarışı önde götürüyor...";
            }

            if (bir_at_en + pictureBox1.Left >= bitis )
            {
                timer1.Enabled=false;
                MessageBox.Show("1. At kazandı");

            }
            else if (iki_at_en + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At kazandı");

            }
            else if (uc_at_en + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At kazandı");

            }




        }   

        private void Form1_Load(object sender, EventArgs e)
        {

            a1s = pictureBox1.Left;
            a2s = pictureBox2.Left;
            a3s = pictureBox3.Left;
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
