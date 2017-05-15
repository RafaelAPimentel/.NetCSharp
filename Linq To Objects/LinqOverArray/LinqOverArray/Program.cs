using System;
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
            QueryOverStrings();
            Console.Read();
        }

        static void QueryOverStrings() {
            string[] currentVideoGames = { "Marrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            foreach (var item in subset) {
                Console.WriteLine("Games that contain a space");
                Console.WriteLine($"Item: {item}");
            }
            
        }
    }
}
