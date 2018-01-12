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
                if (!object.ReferenceEquals(control.GetType(),typeof(System.Web.UI.LiteralControl)))
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
    }
}