using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_grid_olayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;

        private void button1_Click(object sender, EventArgs e)
        {
            i = dataGridView1.Rows.Add(5);
            i = 0;

            dataGridView1.Rows[i].Cells[0].Value =1;
            dataGridView1.Rows[i].Cells[1].Value = "Yunus";
            dataGridView1.Rows[i].Cells[2].Value = "Yaşa";
            dataGridView1.Rows[i].Cells[3].Value = "Astronot";
            dataGridView1.Rows[i].Cells[4].Value = "Konya";

            i = 1;
           
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;        
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "AD";
            dataGridView1.Columns[2].Name = "SOYAD";
            dataGridView1.Columns[3].Name = "MESLEK";
            dataGridView1.Columns[4].Name = "ŞEHİR";
        }
    }
}
