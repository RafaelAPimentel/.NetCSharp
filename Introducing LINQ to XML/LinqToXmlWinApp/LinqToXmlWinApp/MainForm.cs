using System;
using System.Windows.Forms;

namespace LinqToXmlWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Display currenet XML inventory document in TextBox control
            txtInventory.Text = LinqtoXmlObjectModel.GetXmlInventory().ToString();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            //Add new item to doc
            LinqtoXmlObjectModel.InsertNewElement(txtMake.Text,txtColor.Text,txtPetName.Text);

            //Display current XML inventory document in TextBox control
            txtInventory.Text = LinqtoXmlObjectModel.GetXmlInventory().ToString();
            txtMake.Clear();
            txtColor.Clear();
            txtPetName.Clear();
        }

        private void btnLookUpColors_Click(object sender, EventArgs e)
        {
            txtMakeToLookUp.Clear();
            LinqtoXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
        }
    }
}
