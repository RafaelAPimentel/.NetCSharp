using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Method Group Conversion ****");
            Car c1 = new Car();

            //Register the simple method name
            c1.RegisterWithCarEngine(CallMeHere);
            Console.WriteLine("**** Speeding up ****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //unregister the simple method name
            c1.UnRegisterWithCarEngine(CallMeHere);
            c1 = new Car();
            Console.WriteLine("****** Speeding up ******");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.Read();
        }
        static void CallMeHere(string msg) {

            Console.WriteLine("=> Message from Car: {0}",msg);
        }
    }
}
