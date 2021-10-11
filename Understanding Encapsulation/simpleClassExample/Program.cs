using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClassExample
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("*****Fun with  Car Class Types *****\n");
            Car myCar = new Car();
            Car SecondCar = new Car();
            myCar.petName = "Michael Scott";
            myCar.currSpeed = 10;

            for (int i = 0; i < 10; i++)
            {
                myCar.speedUp(5);
                myCar.printState();
            }
            SecondCar.printState();

            Console.WriteLine("*****Fun with  Motorcycle Class Types *****\n");
            Motorcycle c = new Motorcycle(5);
            c.setDriverName("Darth Vader");
            c.PopAWheely();
            Console.WriteLine($"rider name id {c.driverName}");
            Console.WriteLine("============");
            MakeSomeBikes();
        }
        public static void MakeSomeBikes()
        {
            Motorcycle m1 = new Motorcycle();
            Console.WriteLine($"Name= {m1.driverName}, Intensity = {m1.driverIntensity}");

            Motorcycle m2 = new Motorcycle(name: "tiny");
            Console.WriteLine($"name= {m2.driverName}, intensity = {m2.driverIntensity}");

            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine($"name= {m3.driverName}, intensity = {m3.driverIntensity}");
        }
    }
}
