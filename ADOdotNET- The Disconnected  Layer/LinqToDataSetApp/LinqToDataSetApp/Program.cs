using AutoLotDAL3.DataSets;
using AutoLotDAL3.DataSets.AutoLotDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace LinqToDataSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** LINQ over DataSet ****\n");

            //Get a strongly typed DataTable containing the current Inventory
            // of the AutoLot Database
            AutoLotDataSet dal = new AutoLotDataSet();
            InventoryTableAdapter tableAdapter = new InventoryTableAdapter();
            AutoLotDataSet.InventoryDataTable data = tableAdapter.GetData();

            //Invoke the methods that follow here!
            PrintAllCarIDs(data);
            ShowRedCars(data);
            ReadLine();
         }

        private static void ShowRedCars(DataTable data)
        {
            //Project a new result set containing
            //the ids/color for rows where color = red
            var cars = from car in data.AsEnumerable()
                       where car.Field<string>("Color") == "Black"
                       select new
                       {
                           ID = car.Field<int>("CarID"),
                           Make = car.Field<string>("Make")
                       };
            WriteLine($"Here are the red cars we have in stock:");
            foreach (var item in cars)
            {
                WriteLine($"-> CarID = {item.ID} is {item.Make}");
            }
        }

        private static void PrintAllCarIDs(DataTable data)
        {
            //Get enumerable version of DataTable.
            EnumerableRowCollection enumData = data.AsEnumerable();

            //Print the car IDs values
            foreach (DataRow r in enumData)
            {
                WriteLine($"Car ID = {r["CarID"]}");
            }
        }
    }
}
