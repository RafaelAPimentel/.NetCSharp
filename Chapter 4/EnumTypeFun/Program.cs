using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypeFun
{
    class Program
    {

        enum EmpType : byte
            
        {
            Manager = 0,
            Grunt = 10,
            Contractor = 20,
            VicePresident = 30 
        }
        static void Main(string[] args)
        {
            Console.WriteLine( "=> Fun with Enums");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            //using GetType method
            Console.WriteLine("EmpType uses {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            //using typeof method
            Console.WriteLine("EmpType uses {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));

            Console.WriteLine("Emp is a {0} ", emp.ToString());

            //print out enum name and value
            Console.WriteLine("{0} = {1}", emp.ToString(),(byte)emp);
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(day);
            Console.ReadKey();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead!");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have to be kidding");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("you already get enough cash");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very GOOD, sir");
                    break;
            }
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}",e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members",enumData.Length);

            foreach(System.Enum by in enumData)
                Console.WriteLine("the name is {0} and value is {0:d}", by);


        }
    }
}
