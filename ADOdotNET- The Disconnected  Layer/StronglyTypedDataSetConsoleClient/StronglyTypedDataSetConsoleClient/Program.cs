using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL3.DataSets;
using AutoLotDAL3.DataSets.AutoLotDataSetTableAdapters;
using static System.Console;
using System.Data;

namespace StronglyTypedDataSetConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Strongly Typed DataSets ****\n");

            //CAller create the dataset object
            var table = new AutoLotDataSet.InventoryDataTable();

            //Inform a dapter of the SELECT command text connection
            var adapter = new InventoryTableAdapter();

            
            //Fill our dataset with a new table, named inventory
            adapter.Fill(table);

            PrintInventory(table);
            //Add rows, update and reprint
            AddRecord(table, adapter);
            table.Clear();
            adapter.Fill(table);
            PrintInventory(table);
            Console.ReadLine();
        }

        private static void PrintInventory(AutoLotDataSet.InventoryDataTable table)
        {
            //Print out the column names

            foreach (var tableColumn in table.Columns)
            {
                Write(tableColumn + "\t");
            }
            WriteLine("\n-------------------------------");

            //print the datatable
            foreach (DataRow item in table.Rows)
            {
                Write($"{item["Carid"].ToString()}\t");
                Write($"{item["Make"].ToString()}\t");
                Write($"{item["Color"].ToString()}\t");
                Write($"{item["PetName"].ToString()}\t");
                WriteLine();
            }
            //use either or
            //for (int curRow = 0; curRow < table.Rows.Count; curRow++)
            //{
            //    for (int curCol = 0; curCol < table.Columns.Count; curCol++)
            //    {
            //        Write($"{table.Rows[curRow][curCol] }\t");
            //    }
            //    WriteLine();
            //}
        }

        public static void AddRecord(AutoLotDataSet.InventoryDataTable table,InventoryTableAdapter adapter) {
            try
            {
                //Get a new strongly typed row from the table.
                AutoLotDataSet.InventoryRow newRow = table.NewInventoryRow();

                //Fill row with some sample data
                newRow.Color = "Purple";
                newRow.Make = "BMW";
                newRow.PetName = "Saku";

                //Insert the new row
                table.AddInventoryRow(newRow);

                //Add one more row, using overloade add method
                table.AddInventoryRow("Yugo","Green","Zippy");

                //update database
                adapter.Update(table);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
