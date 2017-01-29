using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Frank", 55, "Red");

            WriteLine($"Your car name is {myCar.PetName}? That's odd...");
            myCar.DisplayStatus();

            Garage g = new Garage();
            WriteLine("numberofCars: {0}",g.NumberOfCars);
           
            ReadKey();
            
        }
    }
}
