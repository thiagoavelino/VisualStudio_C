using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter9 {
    class MysqlExample {
        public static void Main(){
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=test";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Person (FirstName, LastName) " +
            "VALUES ('Joe', 'Smith')";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            
            cn.Close();
        }
    }
}
