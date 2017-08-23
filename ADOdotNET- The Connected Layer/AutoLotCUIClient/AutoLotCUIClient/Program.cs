using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using static System.Console;
using System.Configuration;
using AutoLotDAL.ConnectedLayer;
using System.Data;
using AutoLotDAL.Models;

namespace AutoLotCUIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** The AutoLot Console UI ****");

            //Get connectionstring form app.config
            string connectionstring = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            bool userDone = false;
            string userCommand = string.Empty;

            //Create out Inventory object
            InventoryDAL invDal = new InventoryDAL();
            invDal.OpenConnection(connectionstring);

            //keep asking for input until user presses Q key
            try
            {
                ShowInstructions();
                do
                {
                    WriteLine("\nPlease enter your command");
                    userCommand = ReadLine();
                    switch (userCommand.ToUpper()??"")
                    {
                        case "I":
                            InsertNewCar(invDal);
                            break;
                        case "U":
                            UpdateCarPetName(invDal);
                            break;
                        case "D":
                            DeleteCar(invDal);
                            break;
                        case "L":
                            ListInventory(invDal);
                            break;
                        case "S":
                            ShowInstructions();
                            break;
                        case "P":
                            LookUpPetName(invDal);
                            break;
                        case "Q":
                            userDone = true;
                            break;
                        default:
                            WriteLine("Bad data! Try again!");
                            break;
                    }
                } while (!userDone);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                invDal.CloseConnection();
            }
        }

        private static void LookUpPetName(InventoryDAL invDal)
        {
            //Get id of the car to look up..
            Write("Enter ID of car to look up: ");
            int id = int.Parse(ReadLine() ?? "0");
            Write($"Petname of {id} is {invDal.LookUpPetName(id).TrimEnd()}.");
        }

        private static void ListInventory(InventoryDAL invDal)
        {
            //Get the list of inventory
            DataTable dt = invDal.GetAllInventoryAsDataTable();
            //Pass datatable to helper function to display
            DisplayTable(dt);
        }

        private static void DisplayTable(DataTable dt)
        {
            //Print out the column names.
            for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
            {
                Write($"{dt.Columns[curCol].ColumnName}\t");
            }
            WriteLine("\n------------------------------------");

            //print datatable
            for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
            {
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write($"{dt.Rows[curRow][curCol]}\t");
                }
                WriteLine();
            }
        }

        private static void DeleteCar(InventoryDAL invDal)
        {
            //Get ID of Car to delete
            Write("Enter ID of Car to delete: ");
            int id = int.Parse(ReadLine() ?? "0");

            //Just in case you have a referential integrity violation
            try
            {
                invDal.DeleteCar(id);
                WriteLine("Car has been deleted");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        private static void UpdateCarPetName(InventoryDAL invDal)
        {
            //First get the user data
            Write("Enter Car ID: ");
            var carID = int.Parse(ReadLine() ?? "0");
            Write("Enter New Pet Name: ");
            var newCarPetName = ReadLine();

            //Now pass to the data access library
            invDal.UpdateCarPetName(carID, newCarPetName);
            Write("Cars name has been changed");
        }

        private static void InsertNewCar(InventoryDAL invDal)
        {
            Write("Enter Car ID: ");
            var newCarID = int.Parse(ReadLine()??"0");
            Write("Enter Car Color: ");
            var newCarColor = ReadLine();
            Write("Enter Car Make: ");
            var newCarMake = ReadLine();
            Write("Enter Pet Name: ");
            var newCarPetName = ReadLine();

            //the insert method takes on a car class 
            var c = new NewCar
            {
                CarId = newCarID,
                Color = newCarColor,
                Make = newCarMake,
                PetName = newCarPetName
            };

            //Now pass to dat access library
            invDal.InsertAuto(c);
            WriteLine("Car has been inserted");
        }

        private static void ShowInstructions()
        {
            WriteLine("I: Insert a new car.");
            WriteLine("U: Update an existing car.");
            WriteLine("D: Deletes and existing car.");
            WriteLine("L: Lists current inventory.");
            WriteLine("S: Shows these Instructions.");
            WriteLine("P: Looks up pet name.");
            WriteLine("Q: Quits program.");
        }
    }
}
