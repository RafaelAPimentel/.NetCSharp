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
            Console.WriteLine("**** Delegates as Events enablers ****");

            //First make a car object
            Car c1 = new Car("Slug", 100, 10);

            //now tell the car which method to call
            //when it wants to send us messages.

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            //Hold on to the delegate object to unregister later
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);


            //speed up (this will trigger the event).
            Console.WriteLine("****** Speeding up ******");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //unregister from the second handler
            c1.UnRegisterWithCarEngine(handler2);
            Console.WriteLine("****** Speeding up ******");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.Read();

        }
        //this is a target for incoming events
        public static void OnCarEngineEvent(string msg) {
            Console.WriteLine("***** Message from car object *****");
            Console.WriteLine("=> {0}",msg);
            Console.WriteLine("***********************************");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
