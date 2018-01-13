using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCtrls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListControlsInPanel();
        }

        private void ListControlsInPanel()
        {
            var theInfo = "";
            theInfo = $"<b>Does the panel have controls? {MyPanel.HasControls()} </b><br/>";
            //Get all the controls in the panel
            foreach (Control control in MyPanel.Controls)
            {
                if (!object.ReferenceEquals(control.GetType(), typeof(System.Web.UI.LiteralControl)))
                {
                    theInfo += "**************<br>";
                    theInfo += $"Control Name: {control}<br>";
                    theInfo += $"ID? {control.ID} <br>";
                    theInfo += $"Control Visable? {control.Visible}<br>";
                    theInfo += $"ViewState? {control.ViewStateMode}<br>";

                }
            }
            lblControlInfo.Text = theInfo;
        }

        protected void btnAddWidget_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                //Assign ID so we can get
                //the text value out later
                //using the income form data
                TextBox t = new TextBox { ID = $"newTextBox{i}" };
                MyPanel.Controls.Add(t);
                ListControlsInPanel();
            }
        }

        protected void btnClearPanel_Click(object sender, EventArgs e)
        {
            //Clear all content from the panel, then relist items.
            MyPanel.Controls.Clear();
            ListControlsInPanel();
        }

        protected void btnGetTextData_Click(object sender, EventArgs e)
        {
            string textBoxValues = "";
            textBoxValues += $"<li>{Request.Form.Get("newTextBox0")}</li><br/>" +
                $"<li>{Request.Form.Get("newTextBox1")}</li><br/>" +
                $"<li>{Request.Form.Get("newTextBox2")}</li><br/>";

            lblTextBoxData.Text = textBoxValues;
        }

        protected void btnMoveNameToLabel_Click(object sender, EventArgs e)
        {
            lblTextBoxText.Text = TextBox1.Text;
        }
    }
}