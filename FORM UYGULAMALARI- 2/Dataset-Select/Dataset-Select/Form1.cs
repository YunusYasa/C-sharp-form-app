using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataset_Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Personel_TableTableAdapter dt = new DataSet1TableAdapters.Personel_TableTableAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.PersonelListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.PersonelEkle(textBox2.Text, textBox3.Text);
            MessageBox.Show("eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.PersonelSil(byte.Parse(textBox1.Text));
            MessageBox.Show("silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt.PersonelGüncelle(textBox3.Text, textBox2.Text, byte.Parse(textBox1.Text));
            MessageBox.Show("güncellendi");
        }
    }
}
