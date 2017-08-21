using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Fun with Data Readers ****");

            //Create a connection string via the builder object
            var cnStringBuilder = new SqlConnectionStringBuilder
            {
                InitialCatalog = "AutoLot",
                DataSource = @"(local)\SQLEXPRESS",
                ConnectTimeout = 30,
                IntegratedSecurity = true
            };

            //Create and open a conneciton
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = cnStringBuilder.ConnectionString;
                connection.Open();

                //New  helper function (see below)
                ShowConnectionStatus(connection);

                //Create a SQL command object
                string sql = "SELECT * FROM Inventory;SELECT * FROM Customers";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                //Obtain a data reader a la ExecuteReader()
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    do
                    {
                        //Loop over the result
                        while (myDataReader.Read())
                        {
                            WriteLine("**** Record ****");
                            for (int i = 0; i < myDataReader.FieldCount; i++)
                            {
                                WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
                            }
                            WriteLine();
                        }
                    } while (myDataReader.NextResult());
                }
            }
            Console.Read();
        }

        private static void ShowConnectionStatus(SqlConnection connection)
        {
            //Show various stats about current connection object
            WriteLine("**** Info about your connection ****");
            WriteLine($"Database locaiton: {connection.DataSource}");
            WriteLine($"Database name: {connection.Database}");
            WriteLine($"Timeout: {connection.ConnectionTimeout}");
            WriteLine($"Connection state: {connection.State}\n");
        }
    }
}
