using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager chucky = new Manager("chucky", 50, 92, 10000, "586-15-4561", 900);
            SalesPerson mike = new SalesPerson("mike", 23, 64, 20000, "123-56-4567", 31);
            chucky.DisplayStats();
            Console.WriteLine();
            mike.DisplayStats();

            CastingExamples();
            Console.Read();
        }

        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9,3000,40000,"222-22-2222",5);

            //Manager "is-an" employee too
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            //PTSales "is-an" SalesPerson too
            SalesPerson Jill = new PTSalesPerson("Jill", 834, 3002, 10000, "111-12-1119", 90);

        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!",emp.Name);
        }
    }
}
