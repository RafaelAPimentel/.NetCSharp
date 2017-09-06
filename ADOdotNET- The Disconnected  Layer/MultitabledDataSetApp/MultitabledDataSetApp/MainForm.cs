using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultitabledDataSetApp
{
    public partial class MainForm : Form
    {
        //Form wide DataSet.
        //Create datset to tore all tables later
        private DataSet _autoLotDs = new DataSet("AutoLot");

        //Make use of command builders to simplify data adapters configuration
        private SqlCommandBuilder _sqlCbInventory;
        private SqlCommandBuilder _sqlCbCustomers;
        private SqlCommandBuilder _sqlCbOrders;

        //Our data adapters (for each table)
        private SqlDataAdapter _invTableAdapter;
        private SqlDataAdapter _custTableAdapter;
        private SqlDataAdapter _ordersTableAdapter;

        //Form wide connection string
        private string _connectionString;

        public MainForm()
        {
            InitializeComponent();

            //get connection string 
            _connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

            //Create adapters
            //Provides the query  string and connection string to connect to the database
            _invTableAdapter = new SqlDataAdapter("Select * from Inventory",_connectionString);
            _custTableAdapter = new SqlDataAdapter("Select * from Customers", _connectionString);
            _ordersTableAdapter = new SqlDataAdapter("Select * from Orders", _connectionString);

            ////auto generate commands
            _sqlCbInventory = new SqlCommandBuilder(_invTableAdapter);
            _sqlCbCustomers = new SqlCommandBuilder(_custTableAdapter);
            _sqlCbOrders = new SqlCommandBuilder(_ordersTableAdapter);

            //fills the dataset with the data table gathered from the database
            _invTableAdapter.Fill(_autoLotDs, "Inventory");
            _custTableAdapter.Fill(_autoLotDs, "Customers");
            _ordersTableAdapter.Fill(_autoLotDs,"Orders");

            //Build relations between tables.
            //mapps the foreign keys to each database
            BuildTableRelationship();

            //Bind to grids
            dataGridViewInventory.DataSource = _autoLotDs.Tables["Inventory"];
            dataGridViewCustomers.DataSource = _autoLotDs.Tables["Customers"];
            dataGridViewOrders.DataSource = _autoLotDs.Tables["Orders"];
        }

        private void BuildTableRelationship()
        {

            //Create CustomerOrder data relation object
            DataRelation dr = new DataRelation("CustomersOrder", _autoLotDs.Tables["Customers"].Columns["CustID"], _autoLotDs.Tables["Orders"].Columns["CustID"]);
            _autoLotDs.Relations.Add(dr);

            //Create InventoryOrder data relation object
            dr = new DataRelation("InventoryOrder", _autoLotDs.Tables["Inventory"].Columns["CarId"], _autoLotDs.Tables["Orders"].Columns["CarId"]);
            _autoLotDs.Relations.Add(dr);
        }

        private void btnUpdateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                _invTableAdapter.Update(_autoLotDs, "Inventory");
                _custTableAdapter.Update(_autoLotDs, "Customers");
                _ordersTableAdapter.Update(_autoLotDs, "Orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetOrderInfo_Click(object sender, EventArgs e)
        {
            string strOrderInfo = string.Empty;

            //get the cust ID in the text box
            int custID = int.Parse(txtCustID.Text);

            //Now based on CustID, get the correct row in Customer table.
            var drsCust = _autoLotDs.Tables["Customers"].Select($"CustId = {custID}");

            strOrderInfo += $"Customer {drsCust[0]["CustID"]}: {drsCust[0]["FirstName"].ToString().Trim()} {drsCust[0]["LastName"].ToString().Trim()} \n";

            //Navigate from customers table to order table
            var drsOrder = drsCust[0].GetChildRows(_autoLotDs.Relations["CustomersOrder"]);
            
            //loop through all orders for this customer
            foreach (DataRow order in drsOrder)
            {
                MessageBox.Show("in foreach");
                strOrderInfo += $"----\nOrder Number: {order["OrderID"]}\n";

                //Get the car referenced by this order
                DataRow[] drsInv = order.GetParentRows(_autoLotDs.Relations["InventoryOrder"]);

                //Get info for SINGLE car info for this order
                DataRow car = drsInv[0];
                strOrderInfo += $"Make: {car["Make"]}\n";
                strOrderInfo += $"Color: {car["Color"]}\n";
                strOrderInfo += $"PetName: {car["PetName"]}\n";
            }
            MessageBox.Show(strOrderInfo,"Order Details");
        }
    }
}
