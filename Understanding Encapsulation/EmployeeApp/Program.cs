using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmp = new Employee("Marvin", 465, 30000);
            myEmp.giveBonus(1000);
            myEmp.DisplayStats();
            myEmp.Name = "Maving the great the great assassin of the world";
            myEmp.DisplayStats();

            ReadKey();

        }
    }
}
