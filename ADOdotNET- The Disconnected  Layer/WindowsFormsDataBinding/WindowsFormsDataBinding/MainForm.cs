using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
    public partial class MainForm : Form
    {

        //A collection of Car object
        List<Car> listCars = null;

        DataTable inventoryTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            //Fill the list with some cars
            listCars = new List<Car>
            {
                new Car{PetName="Chucky",Make="BMW",Color="Green" },
                new Car{PetName="Tiny",Make="Yugo",Color="White" },
                new Car{PetName="Amil",Make="Jeep",Color="Tan" },
                new Car{PetName="Pain Inducer",Make="Caravan",Color="Pink" },
                new Car{PetName="Fred",Make="BMW",Color="Green" },
                new Car{PetName="Sidd",Make="BMW",Color="Black" },
                new Car{PetName="Mel",Make="Firebird",Color="Red" },
                new Car{PetName="Sarah",Make="Colt",Color="Black" },
            };
            CreateDataTable();
        }

        void CreateDataTable()
        {
            //Create table schema
            var carIDColumn = new DataColumn("Id", typeof(int))
            {
                Caption = "Car Id",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            var carMakeColumn = new DataColumn("Make", typeof(string));
            var carColorColumn = new DataColumn("Color", typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string))
            {
                Caption = "Pet Name"
            };
            inventoryTable.Columns.AddRange(new[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            //Iterate over the array list to make rows
            foreach (var c in listCars)
            {
                var newRow = inventoryTable.NewRow();
                newRow["Make"] = c.Make;
                newRow["Color"] = c.Color;
                newRow["PetName"] = c.PetName;
                inventoryTable.Rows.Add(newRow);
            }

            //Bind the data table
            carInventoryGridView.DataSource = inventoryTable;
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                //find the correct row to delete
                DataRow[] rowToDelete = inventoryTable.Select($"Id = {int.Parse(txtCartoRemove.Text)}");

                //Delete it 
                rowToDelete[0].Delete();
                inventoryTable.AcceptChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            DataView something = new DataView(inventoryTable);

            //Build a filter based on user input.
            string filterStr = $"Make = '{txtMakeToView.Text}'";

            //Find all rows matching the filter
            DataRow[] makes = inventoryTable.Select(filterStr);

            //Show what we got!
            if (makes.Length == 0)
            {
                carInventoryGridView.DataSource = inventoryTable;
                MessageBox.Show("Sorry, no cars...\nReturning entire list", "Selection error!");
            }
            else
            {
                something.RowFilter = filterStr;

                carInventoryGridView.DataSource = something;
                //string strMake = null;
                //for (var i = 0; i < makes.Length; i++)
                //{
                //    strMake += makes[i]["PetName"] + "\n";
                //}
                ////now shaow all matches in a message box
                //MessageBox.Show(strMake, $"We have {txtMakeToView.Text}s named:");
            }
        }
    }
}
