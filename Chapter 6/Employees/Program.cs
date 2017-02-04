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

            Console.Read();
        }
    }
}
