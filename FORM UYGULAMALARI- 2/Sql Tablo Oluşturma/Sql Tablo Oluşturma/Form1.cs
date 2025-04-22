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

namespace Sql_Tablo_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Create Table"+textBox1.Text+"(Türİd tinyint....,....,...)");
            //TÜR İD yerinin messageboxdan çekebiliriz ( if nulla belki) comboboxtanda türünü belirtebiliriz. diğre kalan kısımlar bağlantı cart curt işte.
            komut.ExecuteNonquert();
        }
    }
}
