using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connection_String_Class
{
    internal class SqlConnectionss
    {
        public SqlConnection bagla() 
        {
            string baglan = "Data Source=THE-HUNTER\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True;Encrypt=False";
            SqlConnection baglanti = new SqlConnection(baglan);
            return baglanti;

        }
    }
}
