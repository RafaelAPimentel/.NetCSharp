using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numberOfSales)
            : base(fullName, age, empID, currPay, ssn,numberOfSales)
        {
        }


    }
}
