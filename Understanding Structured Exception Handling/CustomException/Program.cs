using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Cutom Exception *****");
            Car myCar = new Car("Rusty", 20);

            try
            {
                for (int i = 0; i < 10 ; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.Read();
        }
    }
}
