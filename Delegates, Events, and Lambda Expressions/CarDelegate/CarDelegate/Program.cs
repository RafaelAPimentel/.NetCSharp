using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a car object
            Car car1 = new Car("SlugBug", 100, 10);

            //now tell the car which method to call 
            //when it wants to send a message
            car1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            car1.RegisterWithCarEngine(handler2);

            //speed up this will trigger the event
            Console.WriteLine("**** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                car1.Accelerate(20);
            }

            //unregister from the second handler
            car1.UnRegisterWithCarEngine(handler2);

            //We wont see the uppercase message anymore
            //for (int i = 0; i < 6; i++)
            //    car1.Accelerate(20);

            Console.ReadKey();
        }

        public static void OnCarEngineEvent(string msg) {
            Console.WriteLine("\n**** Message From Car Object ****");
            Console.WriteLine($"=>{msg}");
            Console.WriteLine("**********************************");
        }
        public static void OnCarEngineEvent2(string msg){
            Console.WriteLine($"=>{msg.ToUpper()}");
        }
    }
}
