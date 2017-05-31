using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to MyTypwViewer");
            string typeName = "";

            do
            {
                Console.WriteLine("**** Enter a type name to evaluate");
                Console.WriteLine("or Enter Q to quit: ");

                typeName = Console.ReadLine();

                if (typeName.ToUpper() == "Q")
                {
                    break;
                }

                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine(" ");
                    ListVariousStats(t);
                    ListFields(t);
                    ListProp(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch (Exception)
                {

                    Console.WriteLine("Sorry cant find type");
                }

            }
            while (true);

        }
        
        static void ListMethods(Type t)
        {
            Console.WriteLine("**** Methods ****");
            var MethodNames = from n in t.GetMethods() select n;
            foreach (var name in MethodNames)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine();
        }

        static void ListFields(Type t)
        {
            Console.WriteLine("**** Fields ****");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var item in fieldNames)
            {
                Console.WriteLine($"->{item}");
            }
            Console.WriteLine();
        }

        static void ListProp(Type t)
        {
            Console.WriteLine("**** Properties ****");
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var item in propNames)
            {
                Console.WriteLine($"->{item}");
            }
            Console.WriteLine();
        }

        static void ListInterfaces(Type t)
        {
            Console.WriteLine("**** Interfaces ****");
            var ifaces = from i in t.GetInterfaces() select i.Name;
            foreach (var item in ifaces)
            {
                Console.WriteLine($"->{item}");
            }
        }

        static void ListVariousStats(Type t)
        {
            Console.WriteLine("**** Various Statistics ****");
            Console.WriteLine($"Base class is {t.BaseType}");
            Console.WriteLine($"Is type abstract? {t.IsAbstract}");
            Console.WriteLine($"Is type sealed? {t.IsSealed}");
            Console.WriteLine($"Is Generic? {t.IsGenericTypeDefinition}");
            Console.WriteLine($"Is type a class type? {t.IsClass}");
            Console.WriteLine();
        }
    }
}
