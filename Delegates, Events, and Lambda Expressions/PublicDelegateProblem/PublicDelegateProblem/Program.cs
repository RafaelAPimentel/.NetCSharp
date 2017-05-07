using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** *Agh! No Encapsulation!***");

            //Make aCar
            Car myCar = new Car();

            //It has direct access to the delegate
            myCar.listOfHandler = new Car.CarEngineHandler(CallWhenExploded);
            myCar.Accelerate(10);

            ////We can assign to a whole new object...
            myCar.listOfHandler = new Car.CarEngineHandler(CallHereToo);
            myCar.Accelerate(10);

            ////the caller can also directlyinvoke delegate!
            myCar.listOfHandler.Invoke("hee, hee, hee....");
            Console.Read();

        }

        private static void CallWhenExploded(string msg) { Console.WriteLine(msg); }
        private static void CallHereToo(string msg) { Console.WriteLine(msg); }
    }
}
