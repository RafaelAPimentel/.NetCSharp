using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** LINQ over Generic Collections ****\n");

            List<Car> myCars = new List<Car>() {
                new Car {PetName="Henry", Color = "Silver", Speed = 100,Make= "BMW" },
                new Car {PetName="Daisy", Color = "Tan", Speed = 90,Make= "BMW" },
                new Car {PetName="Mary", Color = "Black", Speed = 55,Make= "VW" },
                new Car {PetName="Clunker", Color = "Rust", Speed = 5,Make= "Yugo" },
                new Car {PetName="Melvin", Color = "White", Speed = 43,Make= "Ford" }
            };

            GetFastCars(myCars);
            Console.Read();
        }

        static void GetFastCars(List<Car> myCars) {
            //find all cars that have a speed greater than 55
            var fastCars = from c in myCars where c.Speed > 90  && c.Make == "BMW" select c;

            foreach (var item in fastCars)
            {
                Console.WriteLine($"{item.PetName} is going fast! ");
            }
        }
    }
}
