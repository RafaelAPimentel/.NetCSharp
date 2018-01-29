using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["UserTheme"] = "";
        Server.Transfer(Request.FilePath);
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["UserTheme"] = "BasicGreen";
        Server.Transfer(Request.FilePath);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["UserTheme"] = "CrazyOrange";
        Server.Transfer(Request.FilePath);
    }

    protected void Page_PreInit(object sender, EventArgs e) {
        try
        {
            Theme = Session["UserTheme"].ToString();
        }
        catch (Exception)
        {
            Theme = "";
        }
    }
}