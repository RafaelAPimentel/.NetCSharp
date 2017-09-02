using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Fun with DataSets ****\n")
                ;
            //Create the DataSet object and add few properties
            var carsInventoryDS = new DataSet("Car Inventory");

            carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInventoryDS.ExtendedProperties["Company"] = "Mikko's Hot  Tub Super Store";

            FillDataSet(carsInventoryDS);
            PrintDataSet(carsInventoryDS);
            ReadLine();
        }

        private static void PrintDataSet(DataSet ds)
        {
            //Print out teh DataSet name and any extended properties.
            WriteLine($"DataSet is name: {ds.DataSetName}");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                WriteLine($"Key = {de.Key}, Value = {de.Value}");
            }
            WriteLine();
            //Printe out each table using rows and columns
            foreach (DataTable dt in ds.Tables)
            {
                WriteLine($"=>  {dt.TableName} Table:");

                //Print out the column namess.
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write($"{dt.Columns[curCol].ColumnName}\t");
                }
                WriteLine("\n------------------------------------");

                //Print the datatable
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Write($"{dt.Rows[curRow][curCol]}\t");
                    }
                    WriteLine();
                }
            }
        }

        private static void FillDataSet(DataSet ds)
        {
            //create data columns that map to the 
            //"real" columns in the inventory table
            //of the AutoLot database
            var carIDColumn = new DataColumn("CarID", typeof(int)) {
                Caption = "Car ID",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) {
                Caption = "Pet Name"
            };
            //Now add datacolumn to a datatable
            var inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new[] { carIDColumn,carMakeColumn,carColorColumn,carPetNameColumn});

            //Now add some rows to the Inventory Table
            DataRow carRow = inventoryTable.NewRow();
            carRow["Make"] = "BMW";
            carRow["Color"] = "Black";
            carRow["PetName"] = "Hamlet";
            inventoryTable.Rows.Add(carRow);

            carRow = inventoryTable.NewRow();
            //Column 0 is the autoincrement ID field,
            //so start at 1

            carRow[1] = "Saab";
            carRow[2] = "Red";
            carRow[3] = "Sea  Breeze";
            inventoryTable.Rows.Add(carRow);

            //Make the primary key of this table
            inventoryTable.PrimaryKey = new[] { inventoryTable.Columns[0] };

            //finally add our table to the DataSet
            ds.Tables.Add(inventoryTable);
        }
        private static void ManipulateDataRowState() {
            //Create a temp Datatable for testing.
            var temp = new DataTable("Temp");
            temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

            //Row state = Detached
            var row = temp.NewRow();
            WriteLine($"After calling NewRow(): {row.RowState}");

            //RowState = Added
            temp.Rows.Add(row);
            WriteLine($"After calling Rows.Add():  {row.RowState}");

            //RowState = Added
            row["TempColumn"] = 10;
            WriteLine($"After first assignment: {row.RowState}");

            //RowState = unchanged
            temp.AcceptChanges();
            WriteLine($"After calling AcceptChange: {row.RowState}");

            //RowState = Modified
            row["TempColumn"] = 11;
            WriteLine($"After first Assignment: {row.RowState}");

            //RowState = Deleted
            temp.Rows[0].Delete();
            WriteLine($"After calling Delete: {row.RowState}");
        }
    }
}
