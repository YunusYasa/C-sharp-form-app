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

namespace Display_ve_Value_Member
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnc = new SqlConnection("Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Entity;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Personel_Table",cnc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "P_İd";
            comboBox1.DisplayMember = "P_Ad";
            comboBox1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("select * from Firma_Table",cnc);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.ValueMember = "F_İd";
            comboBox2.DisplayMember = "F_Adı";
            comboBox2.DataSource = dt2;

        }
    }
}
