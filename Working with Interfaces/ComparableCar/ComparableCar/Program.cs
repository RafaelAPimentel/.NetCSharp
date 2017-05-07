using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chcky", 40, 5);
            Console.WriteLine("Unordered array");
            foreach (Car c in myAutos)
                Console.WriteLine($"{c.CarID} : {c.PetName}");
            Array.Sort(myAutos);
            Console.WriteLine("\nSorted");
            foreach (Car c in myAutos)
                Console.WriteLine($"{c.CarID } : { c.PetName}");

            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine("\nSorted by PetName");
            foreach (Car c in myAutos)
            {
                Console.WriteLine($"{c.CarID} : {c.PetName }");
            }
            Console.ReadKey();
        }
    }
}
