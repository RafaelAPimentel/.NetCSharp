using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Anonymous Types ****");
            //Make  as anonymous type representing car
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = "55" };

            Console.WriteLine($"My car is a {myCar.Color} {myCar.Make}.");

            BuildAnonType("BMW", "Black", 90);
            Console.Read();
            Console.Beep();
        }
        static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };

            Console.WriteLine($"You have a {car.Color} {car.Make} going {car.Speed} MPH");

            Console.WriteLine($"ToString() = {car.ToString()}");
        }
    }
}
