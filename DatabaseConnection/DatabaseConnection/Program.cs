using System;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace DB_Corporate
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbName = "C:\\databases\\sqlsql.sqlite";
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
            }
            using (var cnn = new SQLiteConnection($"Data Source = {dbName}"))
            {
                cnn.Open();

                //SQLiteCommand createTable = new SQLiteCommand();
                //createTable.Connection = cnn;
                //createTable.CommandText = "CREATE TABLE NEWTABLE (login VARCHAR(31) UNIQUE NOT NULL, password TEXT(31) NOT NULL);";
                //createTable.ExecuteNonQuery();

                SQLiteCommand insert = new SQLiteCommand
                {
                    Connection = cnn,
                    CommandText = @"INSERT INTO NEWTABLE Values (@login, @password)"
                };
                //insert.Parameters.AddWithValue("login12", "IVAN_ADMIN12");
                insert.Parameters.Add(new SQLiteParameter()
                {
                    ParameterName = "@password",
                    Value = "ADMIN_PASSWORD12",
                    DbType = DbType.String
                });
                insert.Parameters.Add(new SQLiteParameter()
                {
                    ParameterName = "@login",
                    Value = "ADMIN_LOGIN12",
                    DbType = DbType.String
                });
                insert.ExecuteNonQuery();

                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From NEWTABLE", cnn);

                adapter.Fill(table);

                SQLiteCommand select = new SQLiteCommand("select count(*) from NEWTABLE", cnn);


                Console.WriteLine("Number of Rows: " + table.Rows.Count);
                Console.WriteLine("Number of Columns: " + table.Columns.Count);
                Console.WriteLine("---------------------");
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row[0] + " " + row[1]);
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("TableName:" + table.TableName);
                Console.WriteLine("Number of Rows: " + select.ExecuteScalar());
                Console.ReadKey();
            }
        }
    }
}