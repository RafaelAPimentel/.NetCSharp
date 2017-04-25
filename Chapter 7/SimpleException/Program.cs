using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Simple Exception Example*****");
            Console.WriteLine("=> Creating a car and stepping on it");
            Car myCar = new Car("Xippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("*****Error*****");
                Console.WriteLine("Member name: {0}" + e.TargetSite);
                Console.WriteLine("Class defying member: {0}" + e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}" + e.TargetSite.MemberType);
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("Source: " + e.Source);
                Console.WriteLine("Stack: " + e.StackTrace);
                Console.WriteLine("Helpdata: " + e.HelpLink);
                Console.WriteLine("Custom data");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}:{1}", de.Key,de.Value);
                


            }

            Console.ReadLine();
        }
    }
}
