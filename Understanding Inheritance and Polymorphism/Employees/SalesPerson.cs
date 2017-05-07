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

        //Methods
        public override void giveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;

            }
            else {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else {
                    salesBonus = 20;
                }
            }
            base.giveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}",SalesNumber);
        }


    }
}
