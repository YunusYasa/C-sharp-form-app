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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True;Encrypt=False");
        private void veri()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Kitaplar", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["KitapAd"].ToString());
                ekle.SubItems.Add(oku["Yazar"].ToString());
                ekle.SubItems.Add(oku["Yayınevi"].ToString());
                ekle.SubItems.Add(oku["Sayfa"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            veri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Insert into Kitaplar (ID,Kitapad,Yazar,Yayınevi,Sayfa) values ('" +textBox1.Text.ToString()+ "', '" +textBox2.Text.ToString()+ "','" +textBox3.Text.ToString()+ "','" +textBox4.Text.ToString()+ "','" +textBox5.Text.ToString()+ "')",baglan);
            komut2.ExecuteNonQuery();
            baglan.Close();
            veri();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
            textBox4.Clear();
            textBox5.Clear();      
        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from Kitaplar where ID =(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close() ;
            veri();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Kitaplar set ID ='"+textBox1.Text.ToString()+"',Kitapad ='" +textBox2.Text.ToString() + "',Yazar ='" + textBox3.Text.ToString() + "',Yayınevi ='" + textBox4.Text.ToString() + "',Sayfa ='" + textBox5.Text.ToString() +"'where ID = "+id+"",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veri();

        }
    }
}