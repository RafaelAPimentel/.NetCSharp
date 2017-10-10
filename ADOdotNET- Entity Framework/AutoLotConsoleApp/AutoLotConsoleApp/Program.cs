using AutoLotConsoleApp.EF;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Fun with ADO.NET EF ****\n");
            //int carid = AddNewRecord();
            //WriteLine(carid);
            //PrintAllInventory();
            FunWithLinqQueries();
            ReadLine();
        }

        private static int AddNewRecord()
        {
            //Add record to the Inventory table to the AutoLot
            //Database
            using (var context = new AutoLotEntities())
            {
                try
                {
                    //Hard-code data for a new record, for testing.
                    var car = new Car() { Make = "Yugo", Color = "Brown", CarNickName = "Brownie"};
                    context.Cars.Add(car);
                    context.SaveChanges();
                    //On a successful save, EF populates the database generated identity field.
                    return car.CarId;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return 0;
                }
            }
        }

        private static void PrintAllInventory() {
            //Select all items from the Inventory table of AutoLot,
            //and print out the data using our custom ToString()
            //of the Car Entity class
            using (var context = new AutoLotEntities())
            {
                //foreach (Car c in context.Cars)
                //{
                //    WriteLine(c);
                //}
                //foreach (Car c in context.Cars.SqlQuery("SELECT CarId,Make,Color,PetName as CarNickName from Inventory where Make=@p0", "BMW"))
                //{
                //    WriteLine(c);
                //}
                foreach (Car c in context.Cars.Where(c=>c.Make == "BMW"))
                {
                    WriteLine(c);
                }
            }
        }

        private static void FunWithLinqQueries() {
            using (var context = new AutoLotEntities())
            {
                //Get all data from the inventory table
                //Could also write:
                //var allData = (from item in context.Cars select item).ToArray();
                var allData = (from item in context.Cars select item).ToArray();
                //Get a projection of a new data
                var colorsMake = from item in context.Cars select new { item.Color, item.Make };
                foreach (var item in colorsMake)
                {
                    WriteLine(item);
                }

                //Get only items where color == "Black"
                var blackCars = from item in context.Cars where item.Color == "Black" select item;
                foreach (var item in blackCars)
                {
                    WriteLine(item);
                }


            }
        }
    }
}
