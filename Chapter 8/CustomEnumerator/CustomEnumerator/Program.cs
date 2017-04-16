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
            Console.WriteLine("**** Fun with  IEnumerable / IEnumerator ****\n");
            Garage carLot = new Garage();

            //and over each car in the collection?
            foreach (Car c in carLot) {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed}");
            }
            Console.ReadKey();
        }
    }
}
