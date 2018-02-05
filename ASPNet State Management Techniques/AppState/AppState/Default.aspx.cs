using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnShowAppVariables_Click(object sender, EventArgs e)
    {
        CarLotInfo appVar = ((CarLotInfo)Application["CarSiteInfo"]);
        string appState = $"<li>Car on sale: {appVar.CurrentCarOnSales}</li>";
        appState += $"<li> Most popular color: {appVar.MostPopularColorOnLot} </li>";
        appState += $"<li>Big shot SalesPerson: {Application["SalesPersonOfTheMonth"]} </li>";
        lblAppVariables.Text = appState;
    }

    protected void btnSetSalePerson_Click(object sender, EventArgs e)
    {
        Application.Lock();
        Application["SalesPersonOfTheMonth"] = txtSetSalesPerson.Text;
        Application["CurrentBonusedEmployee"] = Application["SalesPersonOfTheMonth"];
        Application.UnLock();
    }
}