using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryOverStrings();
            QueryOverInts();
            Console.Read();
        }

        static void QueryOverStrings() {
            string[] currentVideoGames = { "Marrowind", "Uncharted 2", "Fallout 3", "Daxt2er", "System Shock 2" };

            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         where g.Contains("2")
                                         orderby g
                                         select g;

            Console.WriteLine("Games that contain a space and 2");
            foreach (var item in subset) {
                
                Console.WriteLine($"Item: {item}");
            }
            
        }

        static void ImmediateExecution() {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray();

            List<int> subsetAsIntList = (from i in numbers where i < 10 select i).ToList();
        }

        static void QueryOverInts() {
            int[] numbers = {10,20,30,40,1,2,3,8 };
            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("Numbers under ten");
            foreach (var item in subset)
            {
                Console.WriteLine($"items: {item}");

            }
        }
    }
}
