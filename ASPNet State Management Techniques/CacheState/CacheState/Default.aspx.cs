using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Collections.Generic;
using System.Web.Caching;

public partial class _Default : System.Web.UI.Page
{
    //Define a static level Cache member variable
    static Cache _theCache;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            carsGridView.DataSource = (IList<Inventory>)Cache["AppDataTable"];
            carsGridView.DataBind();
        }
        else {
            RefreshGrid();
        }
    }

    void Application_Start(object sender, EventArgs e) {
        //First assign  the static "theCache" variable
        _theCache = Context.Cache;

        //When the application starts up,
        //read the current records in the 
        //Inventory table of the AutoLot DB
        var theCars = new InventoryRepo().GetAll();

        //Now store the datatable in the cache
        _theCache.Insert("CarList",
            theCars,
            null,
            DateTime.Now.AddSeconds(15),
            Cache.NoSlidingExpiration,
            CacheItemPriority.Default,
            UpdateCarInventory);
    }

    //the target for the CacheItemRemovedCallBack delegate
    static void UpdateCarInventory(string key, object item, CacheItemRemovedReason reason) {
        var theCars = new InventoryRepo().GetAll();
        //Now store in the cache
        _theCache.Insert("CarList", 
            theCars, 
            null,
            DateTime.Now.AddSeconds(15),
            Cache.NoSlidingExpiration,
            CacheItemPriority.Default,
            UpdateCarInventory);
    }

    protected void btnAddCar_Click(object sender, EventArgs e)
    {
        //Update inventory table
        //and call RefreshGgrid()
        new InventoryRepo().Add(new Inventory()
        {
            Color = txtCarColor.Text,
            Make = txtCarMake.Text,
            PetName = txtCarPetName.Text
        });
        RefreshGrid();
    }

    private void RefreshGrid() {
        carsGridView.DataSource = new InventoryRepo().GetAll();
        carsGridView.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        new InventoryRepo().Delete(int.Parse(txtCarToDelete.Text));
        RefreshGrid();
    }
}