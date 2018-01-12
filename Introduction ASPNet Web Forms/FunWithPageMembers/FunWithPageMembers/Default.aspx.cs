using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FunWithPageMembers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGetBrowserStats_Click(object sender, EventArgs e)
        {
            string theInfo = "";
            theInfo += $"<li>Is the client AOL? {Request.Browser.AOL}</li>";
            theInfo += $"<li>Does the client support ActiveX? {Request.Browser.ActiveXControls}</li>";
            theInfo += $"<li>Is the client a beta? {Request.Browser.Beta}</li>";
            theInfo += $"<li>Is the client support Java Applets? {Request.Browser.JavaApplets}</li>";
            theInfo += $"<li>Is the client Cookies? {Request.Browser.Cookies}</li>";
            theInfo += $"<li>Is the client VBScripts? {Request.Browser.VBScript}</li>";
            lblOutput.Text = theInfo;
        }

        protected void btnGetFormData_Click(object sender, EventArgs e)
        {
            //Get value for a widget with ID txtFirstName
            //string firstName = txtFirstName.Text;
            string firstNameFormRequest = Request.Form["txtFirstName"];
            lblOutput.Text = firstNameFormRequest;
        }

        protected void btnHttpResponse_Click(object sender, EventArgs e)
        {
            Response.Write("<b>My name is: </b><br>");
            Response.Write(this.ToString());
        }

        protected void btnWasteTime_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.facebook.com");
        }
    }
}