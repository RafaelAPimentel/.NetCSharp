using System;
using System.Web.UI.WebControls;
using ValidatorCtrls.App_Code;

namespace ValidatorCtrls
{
    public partial class Annotations : System.Web.UI.Page
    {
        private Inventory _model = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SaveCar(Inventory car) {
            if (ModelState.IsValid)
            {
                _model = car;
                //Add new record here
            }
        }

        public void UpdateCar(Inventory car) {
            if (TryUpdateModel(car))
            {
                _model = car;
                //update record car
            }
        }

        public Inventory GetCar() => _model;
        protected void fvDataBinding_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }
    }
}