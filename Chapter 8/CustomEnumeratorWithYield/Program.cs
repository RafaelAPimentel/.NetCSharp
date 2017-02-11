using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Yield Keyword ****");
            Garage carlot = new Garage();
            Console.WriteLine("In Order");
            //using getEnumerators 
            foreach (Car item in carlot)
            {
                Console.WriteLine("{0} is going {1} MPH",item.PetName,item.CurrentSpeed);
            }
            Console.WriteLine();
            Console.WriteLine("In Reverse");
            //get items in reverse using named iterator
            foreach (Car item in carlot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH",item.PetName,item.CurrentSpeed);
            }
            Console.Read();
        }
    }
}
