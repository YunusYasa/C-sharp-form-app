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

namespace Site_Emlak_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Siteler;Integrated Security=True;Encrypt=False");

        private void veri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sitabilgi",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());

                listView1.Items.Add(ekle);  
            }
            baglanti.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak Sitesi")
            {
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Fuchsia;
                button3.BackColor= Color.Fuchsia;
                button4.BackColor = Color.Fuchsia;
            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                button2.BackColor = Color.Fuchsia;
                button1.BackColor = Color.Fuchsia;
                button3.BackColor = Color.Fuchsia;
                button4.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Gül Sitesi")
            {
                button2.BackColor = Color.Fuchsia;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Fuchsia;
                button4.BackColor = Color.Fuchsia;

            }
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                button2.BackColor = Color.Fuchsia;
                button1.BackColor = Color.Fuchsia;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Fuchsia;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            veri();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into sitabilgi(id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBox7.Text.ToString()+ "','"+comboBox1.Text.ToString()+"','"+comboBox3.Text.ToString()+"','"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+comboBox4.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+textBox6.Text.ToString()+"','"+textBox5.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+comboBox2.Text.ToString()+"')",baglanti);
        
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri();
        }
        int id = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from sitabilgi where id =(" + id + ")", baglanti);
            
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            veri();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Burda sikko bir hata vveriyor boşver amk
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update sitabilgi set id='" +textBox7.ToString()+ "',site='" +comboBox1.Text.ToString()+ "',oda='" +comboBox3.Text.ToString()+ "',metre='" +textBox1.Text.ToString()+ "',fiyat='" + textBox2.Text.ToString()+ "',blok='" + comboBox4.Text.ToString()+ "',no='" + textBox3.Text.ToString()+ "',adsoyad='" + textBox6.Text.ToString()+ "',telefon='" + textBox5.Text.ToString()+ "',notlar='" + textBox4.Text.ToString()+ "',satkira='" + comboBox2.Text.ToString()+ "'where id =" + id + "",baglanti);  
            cmd.ExecuteNonQuery();
            baglanti.Close(); 
            veri();
        }
    }
}
