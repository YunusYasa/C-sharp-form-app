using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SOLID___Single_Responsibilty
{
    internal class EmployeeConnection
    {

        public static SqlConnection con = new SqlConnection("Data Source=THE-HUNTER\\" +
            "SQLEXPRESS;Initial Catalog=Entity;Integrated Security=True;Encrypt=False");


    }
}
