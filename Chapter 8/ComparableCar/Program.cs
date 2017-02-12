using System;
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
            myAutos[2] = new Car("Viper", 50, 34);
            myAutos[3] = new Car("Mel", 20, 4);
            myAutos[4] = new Car("Chucky", 10, 5);
            Console.WriteLine("SORTING BY CARID");
            Console.WriteLine("Unordered set of cars: ");
            foreach (Car cc in myAutos)
                Console.WriteLine("{0} :{1}",cc.PetName,cc.CarID);

            Console.WriteLine();
            Array.Sort(myAutos);
            Console.WriteLine("Ordered set of Cars:");
            foreach (Car cc in myAutos)
                Console.WriteLine("{0 }: {1 }",cc.PetName,cc.CarID);

            Console.WriteLine();
            Console.WriteLine("SORTING BY PETNAME");
            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine("Ordering by pet name");
            foreach (Car cc in myAutos)
                Console.WriteLine("{0} {1}", cc.CarID,cc.PetName);
            Console.Read();
        }
    }
}
