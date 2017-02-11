using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with IEnumerable / Ienumerator ****");
            Garage carLot = new Garage();

            foreach (Car item in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", item.PetName,item.CurrentSpeed);
            }

            Console.Read();
        }
    }
}
