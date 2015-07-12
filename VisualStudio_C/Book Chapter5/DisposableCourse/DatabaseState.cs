using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace VisualStudio_C.Book_Chapter5.DisposableCourse {
    public class DatabaseState : IDisposable {
        private MySqlConnection _connection;

        public string GetDate() {
            if(_connection == null) {
                string connStr = "server=localhost;user=root;database=test;port=3306;password=1234;Max Pool Size=500;";
                _connection = new MySqlConnection(connStr);
                _connection.Open();
            }
            using(var command = _connection.CreateCommand()) {
                command.CommandText = "SELECT CURDATE();";
                return command.ExecuteScalar().ToString();
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing) {
            var action = disposing ? "Disposing" : "Finalizing";
            Console.WriteLine("{0}, SqlConnection: {1}", action, _connection.GetHashCode());
            if(disposing) {
                _connection.Close();
                _connection.Dispose();
            }
        }

        ~DatabaseState() {
            Dispose(false);
        }
    }
}
