using AutoLotDAL.EF;
using System.Data.Entity;
using static System.Console;
using AutoLotDAL.Repos;
using AutoLotDAL.Models;
using System.Collections.Generic;

namespace AutoLotTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DataInitializer());
            WriteLine("**** Fun with ADO.NET EF code First ****\n");
            var car1 = new Inventory() { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
            var car2 = new Inventory() { Make = "SmartCar", Color = "Brown", PetName = "Shorty" };
            AddNewRecord(car1);
            AddNewRecord(car2);
            AddNewRecords(new List<Inventory> { car1, car2 });
            UpdateRecord(car1.CarId);
            PrintAllInventory();

            ShowallOrders();
            ReadLine();
        }

        private static void PrintAllInventory()
        {
            using (var repo = new InventoryRepo())
            {
                foreach (Inventory c in repo.GetAll())
                {
                    WriteLine(c);
                }
            }
        }
        private static void AddNewRecord(Inventory car)
        {
            //Add Record to the inventory table of the Autolot
            //database
            using (var repo = new InventoryRepo())
            {
                repo.Add(car);
            }
        }

        private static void AddNewRecords(IList<Inventory> cars)
        {
            //Add Records to the inventory table of the Autolot
            //database
            using (var repo = new InventoryRepo())
            {
                repo.AddRange(cars);
            }
        }

        private static void UpdateRecord(int carId) {
            using (var repo = new InventoryRepo())
            {
                //Grab the carID, change it ,Save!
                var carToUpdate = repo.GetOne(carId);
                if (carToUpdate !=null)
                {
                    WriteLine("Before change: " + repo.Context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    WriteLine("After change: " + repo.Context.Entry(carToUpdate).State);
                    repo.Save(carToUpdate);
                    WriteLine("After save" + repo.Context.Entry(carToUpdate).State);
                   
                }

            }
        }

        private static void ShowallOrders() {
            using (var repo = new OrderRepo())
            {
                WriteLine("*************** Pending orders ***************");
                foreach (var item in repo.GetAll())
                {
                    WriteLine($"->{item.Customer.FullName} is waiting on {item.Car.PetName}");
                }
            }
        }
    }
}
