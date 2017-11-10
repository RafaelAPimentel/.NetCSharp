using AutoLotDAL.EF;
using System.Data.Entity;
using static System.Console;
using AutoLotDAL.Repos;
using AutoLotDAL.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace AutoLotTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DataInitializer());
            WriteLine("**** Fun with ADO.NET EF code First ****\n");
            //var car1 = new Inventory() { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
            //var car2 = new Inventory() { Make = "SmartCar", Color = "Brown", PetName = "Shorty" };
            //AddNewRecord(car1);
            //AddNewRecord(car2);
            //AddNewRecords(new List<Inventory> { car1, car2 });
            //UpdateRecord(car1.CarId);
            PrintAllInventory();

            //ShowAllOrders();
            //ShowAllOrdersEagleryFetched();
            //var customerRepo = new CustomerRepo();
            //var customer = customerRepo.GetOne(4);
            //customerRepo.Context.Entry(customer).State = EntityState.Detached;
            //PrintAllCustomersAndCreditRisk();
            //MakeCustomerARisk(new CustomerRepo().GetOne(6)); //This causes an exception to be thrown
            //UpdateRecordWithConcurrency();
        }

        private static void UpdateRecordWithConcurrency()
        {
            var car = new Inventory { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
            AddNewRecord(car);
            var repo1 = new InventoryRepo();
            var car1 = repo1.GetOne(car.CarId);
            car1.PetName = "Updated";

            var repo2 = new InventoryRepo();
            var car2 = repo2.GetOne(car.CarId);
            car2.Make = "Nissan";
            repo1.Save(car1);
            try
            {
                repo2.Save(car2);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                WriteLine(ex);

            }
            RemoveRecordById(car1.CarId, car1.TimeStamp);
        }

        private static void RemoveRecordById(int carId, byte[] timeStamp)
        {
            var repo = new InventoryRepo();
            repo.Delete(carId, timeStamp);
        }

        private static void PrintAllCustomersAndCreditRisk()
        {
            WriteLine("****** Customers ******");
            using (var repo = new CustomerRepo())
            {
                foreach (var cust in repo.GetAll())
                {
                    WriteLine($"->{cust.FirstName} {cust.LastName} is a customer");
                }
            }
            WriteLine("****** Credit Risk ******");
            using (var repo = new CreditRiskRepo())
            {
                foreach (var risk in repo.GetAll())
                {
                    WriteLine($"-> {risk.FirstName} {risk.LastName} is a credit risk!");
                }
            }
        }

        private static CreditRisk MakeCustomerARisk(Customer customer)
        {
            using (var context = new AutoLotEntities())
            {
                context.Customer.Attach(customer);
                context.Customer.Remove(customer);
                var creditRisk = new CreditRisk()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                context.CreditRisks.Add(creditRisk);
                var creditRiskDupe = new CreditRisk()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };
                context.CreditRisks.Add(creditRiskDupe);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    WriteLine(ex);
                }
                catch (Exception ex)
                {
                    WriteLine(ex);
                }
                return creditRisk;
            }
        }

        private static void ShowAllOrdersEagleryFetched()
        {
            using (var context = new AutoLotEntities())
            {
                WriteLine("****** Pending Orders ******");
                var orders = context.Orders
                    .Include(x => x.Customer)
                    .Include(y => y.Car)
                    .ToList();
                foreach (var itm in orders)
                {
                    WriteLine($"->{itm.Customer.FullName} is waiting on {itm.Car.PetName}");
                }
            }
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

        private static void UpdateRecord(int carId)
        {
            using (var repo = new InventoryRepo())
            {
                //Grab the carID, change it ,Save!
                var carToUpdate = repo.GetOne(carId);
                if (carToUpdate != null)
                {
                    WriteLine("Before change: " + repo.Context.Entry(carToUpdate).State);
                    carToUpdate.Color = "Blue";
                    WriteLine("After change: " + repo.Context.Entry(carToUpdate).State);
                    repo.Save(carToUpdate);
                    WriteLine("After save" + repo.Context.Entry(carToUpdate).State);
                }
            }
        }

        private static void ShowAllOrders()
        {
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
