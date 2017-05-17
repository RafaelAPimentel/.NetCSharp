using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** LINQ Return Values ****\n");
            
            foreach (string  item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        private static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;

            return theRedColors.ToArray();
        }
    }
}
