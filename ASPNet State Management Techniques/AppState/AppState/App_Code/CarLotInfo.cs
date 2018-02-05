using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarLotInfo
/// </summary>
public class CarLotInfo
{

    public string SalesPersonOfTheMonth { get; set; }
    public string CurrentCarOnSales { get; set; }
    public string MostPopularColorOnLot { get; set; }

    public CarLotInfo(string salesPerson, string currentCar, string mostPopular)
    {
            SalesPersonOfTheMonth = salesPerson;
            CurrentCarOnSales = currentCar;
            MostPopularColorOnLot = mostPopular;
    }
}