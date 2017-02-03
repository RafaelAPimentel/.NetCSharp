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
            Manager person = new Manager("Joe", 23, 1234, 546, "456-78-9876", 100);
            Console.WriteLine(person.getBenifitsCost());
            Console.Read();
        }
    }
}
