using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicClass();
            Console.Read();
        }

        static void DynamicClass() {
            VeryDynamicClass dyClass = new VeryDynamicClass();
            Console.WriteLine(dyClass.DynamicMethod(10));
        }
        static void InvokeMembersOnDynamicData()
        {
            //it compiles fine but if entered in main method
            //it will throw error
            dynamic textData = "Hello";
            Console.WriteLine(textData.ToUpper());

            //this copiles fine but throws an exception 
            try
            {
                Console.WriteLine(textData.toupper());
                Console.WriteLine(textData.Foo(10, "ee", DateTime.Now));

            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void ChangeDynamicDataType()
        {
            //Decalare a single dynamic data point
            //named "t"
            dynamic t = "Hello";
            Console.WriteLine($"t is of type: {t.GetType()}");

            t = false;
            Console.WriteLine($"t is of of type: {t.GetType()}");

            t = new List<int>();
            Console.WriteLine($"t is of type: {t.GetType()}");
        }
        static void ImplicitTypedVariable()
        {
            // a is a type List<int>
            var a = new List<int>();
            //this would be a compile-time error
            // a = "Hello";
        }
        static void UseObjectVariable()
        {
            //Assume we have a class named person
            object o = new Person() { FirstName = "Mike", LastName = "Larson" };

            //mus cast object as person to gain access
            //to the person property
            Console.WriteLine($"Person's first name is {((Person)o).FirstName}");
        }
        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "From";
            dynamic s3 = "Minneapolis";
            Console.WriteLine($"s1 is of type: {s1.GetType()}");
            Console.WriteLine($"s2 is of type: {s2.GetType()}");
            Console.WriteLine($"s3 is of type: {s3.GetType()}");
        }
    }

}
