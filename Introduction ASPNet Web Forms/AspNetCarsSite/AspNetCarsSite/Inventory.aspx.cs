using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Collections;
using System.Linq;
using System.Web.ModelBinding;

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

        public IQueryable<Inventory> GetData([Control("cboMake")] string make = "") {
            return string.IsNullOrEmpty(make) ? new InventoryRepo().GetAll().AsQueryable() : new InventoryRepo().GetAll().Where(x => x.Make == make).AsQueryable();
        }

        public IEnumerable GetMake() => new InventoryRepo().GetAll().Select(x => new { x.Make }).Distinct();
    }
}