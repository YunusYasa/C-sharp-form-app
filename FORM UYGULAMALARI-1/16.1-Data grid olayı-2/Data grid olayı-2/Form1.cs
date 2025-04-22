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

namespace Data_grid_olayı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True;Encrypt=False");
        private void goster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds =new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            goster("select * from Kisiler");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Insert into Kisiler (KisiNo,Ad,Soyad,Meslek,Sehir,Maas)values (@KisiNo,@Ad,@Soyad,@Meslek,@Sehir,@Maas)",baglanti);
            cmd.Parameters.AddWithValue("@KisiNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@Meslek", textBox4.Text);
            cmd.Parameters.AddWithValue("@Sehir", textBox5.Text);
            cmd.Parameters.AddWithValue("@Maas", textBox6.Text);
            cmd.ExecuteNonQuery();
            goster("Select * from Kisiler");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from Kisiler where KisiNo=@KisiNo",baglanti);
            cmd.Parameters.AddWithValue("@KisiNo",textBox7.Text);
            cmd.ExecuteNonQuery();
            goster("Select * from Kisiler");
            baglanti.Close();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Kisiler set Ad='" + textBox2.Text + "',Soyad ='" + textBox3.Text + "',Meslek='" + textBox4.Text + "',Sehir='" + textBox5.Text +"',Maas='" + textBox6.Text + "'where KisiNo='" + textBox1.Text + "'", baglanti);
            cmd.ExecuteNonQuery();
            goster("Select * from Kisiler");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string KitapNo = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();  
            string Ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Meslek = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Sehir = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string Maas = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();

            textBox1.Text = KitapNo;
            textBox2.Text = Ad;
            textBox3.Text = Soyad;
            textBox4.Text = Meslek;
            textBox5.Text = Sehir;
            textBox6.Text = Maas;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kisiler where AD like '%" + textBox8.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds =new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
