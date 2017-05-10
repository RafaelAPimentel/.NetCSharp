using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class MyExtension
    {
        //this method allows an object to display its assembly
        //it is  defined in
        public static void DisplayDefiningAssembly(this object obj) {
            Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
        }

        public static int ReverseDigit(this int i ) {
            char[] digits = i.ToString().ToCharArray();

            Array.Reverse(digits);

            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }
    }
}
