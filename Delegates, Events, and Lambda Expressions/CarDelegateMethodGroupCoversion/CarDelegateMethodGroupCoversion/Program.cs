using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupCoversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Method Group coversion****");

            Car c1 = new Car();

            //register the simple method name
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("**** Speeding up ****");
            for (int i = 0; i < 20; i++)
            {
                if (!c1.IsCarDead)
                {
                    c1.Accelerate(20);
                }
                else {
                    c1.Accelerate(20);
                    break;
                }
            }

            c1.UnRegisterWithCarEngine(CallMeHere);

            //no more notifications!
            //for (int i = 0; i < 6; i++)
            //{
            //    c1.Accelerate(20);
            //}

            Console.ReadKey();
        }

        static void CallMeHere(string msg) {
            Console.WriteLine($"=> Message form Car: {msg}");
        }
    }
}
