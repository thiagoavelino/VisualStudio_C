using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.SqlLiteExample {
    public class SqlLiteExample {
        public static void MainSqlLite(string[] args) {

            //string path = "MyTestsFile2.txt";

            // Create a file to write to. 
            //using(StreamWriter sw = File.CreateText(path)) {
            //    for(int i = 0; i < 1000; i++) {
            //        sw.WriteLine("update test set someValue = 'test{0}' where id = {0};", i);
            //    }
            //}
            

            var listOfCommands = new List<String>();

            //using(StreamReader sr = File.OpenText(path)) {
            //    string s = "";
            //    while((s = sr.ReadLine()) != null) {
            //        listOfCommands.Add(s);
            //    }
            //}
            //ExecuteBatchSqlNoParameters("CREATE INDEX i on test(id)");

            //Console.ReadKey();

            var stringWithCommands = new StringBuilder();
            for(int i = 0; i < 100001; i++) {
                //stringWithCommands.Append(String.Format("update test set someValue = 'test{0}' where id = {0};"
                //                            , i));
                stringWithCommands.Append(String.Format("insert into test (id, someValue) values({0},'test');", i));
            }

            var initial = DateTime.Now;
            Console.WriteLine("Intial Time: " + initial);
            ExecuteBatchSqlNoParameters(stringWithCommands.ToString());
            var final = DateTime.Now;
            Console.WriteLine("Final Time: " + final);
            Console.ReadKey();

            var sql = "select * from test";
            var m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            var command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
                Console.WriteLine("Id: " + reader["id"] + "\tSomeValue: " + reader["someValue"]);
            Console.ReadKey();


            //SQLiteConnection.CreateFile("MyDatabase.sqlite");
            //var m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            //m_dbConnection.Open();
            //string sql = "CREATE TABLE test (id INT, someValue VARCHAR(500))";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
            //sql = "insert into test (id, someValue) values (1,'test')";
            //command = new SQLiteCommand(sql, m_dbConnection);
            //command.ExecuteNonQuery();
            //sql = "select * from test";
            //command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //while(reader.Read())
            //    Console.WriteLine("Id: " + reader["id"] + "\tSomeValue: " + reader["someValue"]);
            //m_dbConnection.Close();
            //Console.ReadKey();
        }

        public static void ExecuteBatchSqlNoParameters(string commandText) {
                var connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                connection.Open();
                using(DbCommand command = connection.CreateCommand())
                using(DbTransaction transaction = connection.BeginTransaction()) {
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                connection.Close();
                connection.Dispose();


        }

        public static void ExecuteBatchSqlNoParametersParalle(List<string> updateSqlList) {
            

            Parallel.ForEach(updateSqlList, updateSqlText => {
                var connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                connection.Open();
                using(DbCommand command = connection.CreateCommand())
                using(DbTransaction transaction = connection.BeginTransaction()) {
                    command.CommandText = updateSqlText;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                connection.Close();
                connection.Dispose();
            });

            
        }

    }
}
