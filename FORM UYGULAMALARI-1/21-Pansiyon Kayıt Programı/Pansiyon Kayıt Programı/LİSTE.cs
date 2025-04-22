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

namespace Pansiyon_Kayıt_Programı
{
    public partial class KAYIT : Form
    {
        public KAYIT()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Pansiyon;Integrated Security=True;Encrypt=False");

        private void goster()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler",baglanti);
            SqlDataReader oku= cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["SOYAD"].ToString()); //Büyük küçük harf hassasiyeti yok.
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["gtarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["hesap"].ToString());
                ekle.SubItems.Add(oku["ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            goster();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Insert into Musteriler(id,ad,soyad,odano,gtarih,telefon,hesap,ctarih)values('" + textBox1.Text.ToString() + "'" +
                ",'" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "'," +
                "'" + dateTimePicker1.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "'," +
                "'" + dateTimePicker2.Text.ToString() + "' )", baglanti);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into dolu (doluodalar) values ('"+comboBox1.Text+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = ("delete from bos where bosodalar='" + comboBox1.Text + "'");
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listView1.Items.Clear();
            goster();

            textBox1.Clear();
            //devamı var işte
        }

        int id = 0;
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from Musteriler where id=(" + id + ")", baglanti);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into bos (bosodalar) values ('" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = ("delete from dolu where doluodalar='" + comboBox1.Text + "'");
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listView1.Items.Clear();
            goster();


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Musteriler set id='" + textBox1.Text.ToString() + "'" +
                ",ad='" + textBox2.Text.ToString() + "',soyad='" + textBox3.Text.ToString() + "'" +
                ",odano='" + comboBox1.Text.ToString() + "',gtarih='" + dateTimePicker1.Text.ToString() + "'" +
                ",telefon='" + textBox5.Text.ToString() + "',hesap='" + textBox6.Text.ToString() + "'" +
                ",ctarih='" + dateTimePicker2.Text.ToString() + "'where id=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listView1.Items.Clear();
            goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteriler where ad like '%"+textBox7.Text+ "%'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["SOYAD"].ToString()); //Büyük küçük harf hassasiyeti yok.
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["gtarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["hesap"].ToString());
                ekle.SubItems.Add(oku["ctarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void KAYIT_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from bos",baglanti);
            SqlDataReader oda =cmd.ExecuteReader();
            while (oda.Read()) 
            { 
                comboBox1.Items.Add(oda[0].ToString());  
            }
            baglanti.Close();
        }
    }
}
