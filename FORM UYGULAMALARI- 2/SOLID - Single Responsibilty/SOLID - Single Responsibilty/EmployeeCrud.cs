using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Single_Responsibilty
{
    internal class EmployeeCrud
    {
        public void EmployeeList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Personel_Table", EmployeeConnection.con);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
            dr.Close();

        }

        public int EmployeeAdd (EmployeeDef p) 
        {
            SqlCommand cmd2 = new SqlCommand("insert into Personel_Table " +
                "(P_Ad,P_Soyad) values (@p1,@p2)",EmployeeConnection.con);
            if (cmd2.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@p1", p.Name);
            cmd2.Parameters.AddWithValue("@p2", p.Surname);
            //cmd2.Parameters.AddWithValue("@p3", p.School);

            return cmd2.ExecuteNonQuery();
        }
    }
}
