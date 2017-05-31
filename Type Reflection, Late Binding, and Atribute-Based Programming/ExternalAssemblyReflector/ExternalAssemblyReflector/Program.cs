using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ExternalAssemblyReflector
{
    class Program
    {
        static void DisplayTypesInAsm(Assembly asm) {
            Console.WriteLine("**** Types in ASsembly****");
            Console.WriteLine($"->{asm.FullName}");
            Type[] types = asm.GetTypes();
            foreach (Type item in types)
            {
                Console.WriteLine($"Type: {item}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** External Assembly Viewer ****");

            string asmName = "";
            Assembly asm = null;
            

            do
            {
                Console.WriteLine("Enter an assembly to evalutate");
                Console.WriteLine("or Enter Q to quit");

                asmName = Console.ReadLine();

                if (asmName.ToUpper() == "Q")
                {
                    break;
                }

                try
                {
                    asm = Assembly.Load(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, can't find assembly");
                }
            } while (true);
        }
    }
}
