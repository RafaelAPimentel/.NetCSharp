using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using static System.Console;
using System.Configuration;
using System.Data.Common;

namespace FillDataSetUsingSqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Fun with Data Adapters ****\n");

            //getting connectionsstring from app config
            string connectionString = ConfigurationManager.ConnectionStrings["cnnString"].ConnectionString;

            //Caller creates the DataSet object
            DataSet ds = new DataSet("AutoLot");

            //Inform a dapter of the Select command text connection
            SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Inventory", connectionString);

            //Now map DB column names to user-friendly name
            DataTableMapping tableMapping = adapter.TableMappings.Add("Inventory", "Current Inventory");
            tableMapping.ColumnMappings.Add("CarId", "Car Id");
            tableMapping.ColumnMappings.Add("PetName", "Pet Name");

            //Fill our Dataset with a new table, named inventory
            adapter.Fill(ds, "Inventory");

            //Display  contents of DataSet
            PrintDataSet(ds);
            ReadLine();
        }

        private static void PrintDataSet(DataSet ds)
        {
            //Print out ant name and extended pproperties
            WriteLine($"DataSet is named: {ds.DataSetName}");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                WriteLine($"Key: {de.Key}, Value: {de.Value}");
                }
            WriteLine();
            foreach (DataTable dt in ds.Tables)
            {
                WriteLine($"=> {dt.TableName} Table:");
                //Printout the column names
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write(dt.Columns[curCol].ColumnName + "\t");
                }
                WriteLine("\n-----------------------------------");
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    WriteLine();
                }
            }
        }
    }
}
