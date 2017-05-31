using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharedAsmReflector
{
    class SharedAsmReflector
    {
        private static void DisplayInfo(Assembly a) {
            Console.WriteLine("**** Info abou Assembly ****");
            Console.WriteLine($"Loaded from GAC? {a.GlobalAssemblyCache}");
            Console.WriteLine($"Asm Name: {a.GetName().Name}");
            Console.WriteLine($"Asm version: {a.GetName().Version}");
            Console.WriteLine($"asm Culture: {a.GetName().CultureInfo.DisplayName}");
            Console.WriteLine("Here are public Eenums:");

            Type[] types = a.GetTypes();
            var publicEnums = from pe in types where pe.IsEnum && pe.IsPublic select pe;
            foreach (var pe in publicEnums)
            {
                Console.WriteLine(pe);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** The shared Asm Reflector App****");

            string displayName = null;
            displayName = "System.Windows.Forms," + "Version=4.0.0.0," + "PublicKeyToken=b77a5c561934e089," + @"Culture=""";
            Assembly asm = Assembly.Load(displayName);
            DisplayInfo(asm);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}