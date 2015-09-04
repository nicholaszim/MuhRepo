using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\mmichtc\Documents\DepartmentsDB.mdf;Integrated Security=True;Connect Timeout=30; Pooling=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand command1 = new SqlCommand();
            command1.Connection = sqlConnection;
            command1.CommandText = "";
            command1.ExecuteNonQuery();
            SqlDataReader reader1 = command1.ExecuteReader();
            reader1.Read();
        }
    }
}
