using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserShoppingCart
/// </summary>
public class UserShoppingCart
{

    public string DesiredCar { get; set; }
    public string DesiredCarColor { get; set; }
    public float DownPayment { get; set; }
    public bool IsLeased { get; set; }
    public DateTime DateOfPickUp { get; set; }
}