using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        //Constructors
        public Manager() { }
        public Manager(string fullName, int age, int empID, float currPay, string snn, int numberOfOpt)
            : base(fullName, age, empID, currPay, snn)
        {
            StockOptions = numberOfOpt;
        }

        //Properties
        public int StockOptions { get; set; }

        //Methods

        public override void giveBonus(float amount)
        {
            base.giveBonus(amount);
            Random r = new Random();
            StockOptions = r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }

    }
}
