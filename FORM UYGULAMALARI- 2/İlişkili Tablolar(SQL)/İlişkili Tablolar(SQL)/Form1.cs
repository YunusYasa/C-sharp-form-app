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

namespace İlişkili_Tablolar_SQL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Klasik sql bağlantısı +
            SqlCommand cmd = new SqlCommand("select sehirad from tbl_sehirler"/*,baglanti*/);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            //baglanti.close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //baglanti.open();
            SqlCommand sqlCommand = new SqlCommand("select ilcead from tbl_ilceler where ilid =@p1"/*,baglanti*/);
            sqlCommand.Paramaters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0]);
            }
            //baglanti.close
        }
    }
}
