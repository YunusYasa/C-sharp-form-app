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

namespace SQL_Bağlantı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=sSQl;Integrated Security=True;Encrypt=False");
        private void veri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sSQl", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) 
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["Okul"].ToString());
                listView1.Items.Add(ekle);


            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)

        {
            veri(); 
        }
    }
}
