using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            myListBox.Items.Add("One");
            myListBox.Items.Add("Two");
            myListBox.Items.Add("Three");
            myListBox.Items.Add("Four");
        }
    }

    protected void btnAddToVS_Click(object sender, EventArgs e)
    {
        ViewState["CustomViewStateItem"] = "Some user data";
        lblVSValue.Text = (string)ViewState["CustomViewStateItem"];
    }
}