using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

            if (label2.Text == comboBox2.Text && label1.Text== comboBox1.Text)
            {
                pictureBox1.Visible = true;
               
               
                timer1.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\yunus\\Desktop\\1.mp3";
                MessageBox.Show("UYAN KANARYAMMMMM");
                


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
