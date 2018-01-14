using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Linq;

namespace AspNetCarsSite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Delete(int CarId) {
            
            new InventoryRepo().Delete(CarId);
        }

        public async void Update(Inventory inventory) {
            if (ModelState.IsValid)
            {
                await new InventoryRepo().SaveAsync(inventory);
            }
        }

        public IQueryable<Inventory> GetData() => new InventoryRepo().GetAll().AsQueryable();
    }
}