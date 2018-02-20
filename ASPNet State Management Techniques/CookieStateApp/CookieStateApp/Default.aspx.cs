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

    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        HttpCookie theCookie = new HttpCookie(txtCookieName.Text, txtCookieValue.Text);
        //Add the Expire to make the cookie persistent
        theCookie.Expires = DateTime.Now.AddMonths(3);
        Response.Cookies.Add(theCookie);
    }

    protected void btnShowCookie_Click(object sender, EventArgs e)
    {
        string cookieData = "";
        foreach (string s in Request.Cookies)
        {
            cookieData += $"<li><b>Name</b>: {s}, <b>Value</b>: {Request.Cookies[s]?.Value}</li>";
        }
        lblCookieData.Text = cookieData;
    }
}