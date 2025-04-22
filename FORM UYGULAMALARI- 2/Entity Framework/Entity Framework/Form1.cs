using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntityEntities ent = new EntityEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //LİSTELE
            dataGridView1.DataSource = ent.Personel_Table.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //EKLE
            Personel_Table tbl = new Personel_Table();

            tbl.P_Ad = textBox2.Text;
            tbl.P_Soyad = textBox3.Text;
            ent.Personel_Table.Add(tbl);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Personel_Table.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SİL
            int id =Convert.ToInt16(textBox1.Text);

            Personel_Table tbl = ent.Personel_Table.First(f => f.P_İd == id);
            ent.Personel_Table.Remove(tbl);
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Personel_Table.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //GÜNCELLE
            int id = Convert.ToInt16(textBox1.Text);

            Personel_Table tbl = ent.Personel_Table.First(f => f.P_İd == id);
            tbl.P_Ad = textBox2.Text;
            tbl.P_Soyad = textBox3.Text;
            ent.SaveChanges();
            dataGridView1.DataSource = ent.Personel_Table.ToList();
        }
    }
}
