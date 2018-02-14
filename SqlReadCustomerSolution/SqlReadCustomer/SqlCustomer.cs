using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlReadCustomer
{
    public class SqlCustomer
    {
        public void List()        {
          string connStr = @"server=DESKTOP-V1OGCBJ\SQLSERVER;database=SqlTutorial;Trusted_connection=true";
          SqlConnection conn = new SqlConnection(connStr);
          conn.Open();
            if (conn.State != System.Data.ConnectionState.Open){ 
                Console.WriteLine("The connection didn't open.");
                return;
            }
            string sql = "select * from customer";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows) {
                Console.WriteLine("Result has no row.");
                return;
            }
            while (reader.Read())
            {
                string name = reader.GetString(reader.GetOrdinal("Name"));
                Console.WriteLine($"Name is {name}");
            } 
            conn.Close();
        }
    }
}
