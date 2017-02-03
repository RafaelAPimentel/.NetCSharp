using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        //Properties
        public int SalesNumber { get; set; }
        //Constructers
        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empID, float currPay, string snn, int numberOfSales)
        : base(fullName, age, empID, currPay, snn)
        {
            SalesNumber = numberOfSales;
        }
    }
}
