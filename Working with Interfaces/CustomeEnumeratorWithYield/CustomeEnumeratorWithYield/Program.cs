using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fu with Yield Keyword ****");
            Garage carLot = new Garage();

            //Get items using GetEnumerator().
            foreach (Car c in carLot)
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");

            Console.WriteLine();

            //Get items (in reverse) using named iterator
            foreach(Car c in carLot.GetTheCars(true))
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");

            Console.ReadLine();

        }
    }
}
