using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Collections.Generic;

namespace CodeBehindPageModel
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Inventory> GetData()
        {
            Trace.Write("Default.aspx", "Getting Data");
            return new InventoryRepo().GetAll();
        }
    }
}