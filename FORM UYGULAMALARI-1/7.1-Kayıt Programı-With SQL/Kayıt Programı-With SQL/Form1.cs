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
using System.Drawing.Printing;

namespace Kayıt_Programı_With_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True;Encrypt=False");
        
        private void veri()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select *From Gelenler",baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
         

            while (oku.Read()) 
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           veri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Insert into Gelenler (AdSoyad,Firma) values ('" + textBox1.Text.ToString() + " ','" + textBox2.Text.ToString() +"')",baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veri();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
