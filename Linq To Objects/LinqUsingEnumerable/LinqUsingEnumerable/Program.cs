using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringWithOperators();
            QueryStringWithEnumerableAndLambdas();
            QueryStringWithEnumerableAndLambdas2();
            QueryStringWithAnonymousMethods();
            VeryComplexQueryExpression.QueryStringWithRawDelegates();
            Console.Read();
        }

        private static void QueryStringWithOperators()
        {
            Console.WriteLine("**** Using Query Operators ****");

            string[] currentVideoGames = { "Marrowind", "Uncahrted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var subset = from game in currentVideoGames where game.Contains(" ") orderby game select game;
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.WriteLine();
        }

        private static void QueryStringWithEnumerableAndLambdas2()
        {
            Console.WriteLine("**** Using Enumerable / Lambda Expressions ****");

            string[] currentVideoGames = { "Marrowind", "Uncahrted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.WriteLine();
        }

        private static void QueryStringWithEnumerableAndLambdas()
        {
            Console.WriteLine("**** Using Enumerable / Lambda Expressions *****");

            string[] currentVideoGames = { "Marrowind", "Uncahrted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var gamesWithSpace = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gamesWithSpace.OrderBy(game => game);
            var subset = orderedGames.Select(game=>game);
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.WriteLine();
        }

        private static void QueryStringWithAnonymousMethods()
        {
            Console.WriteLine("**** Using Anonymous Methods *****");

            string[] currentVideoGames = { "Marrowind", "Uncahrted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //Build func delegates using anonymous methods to pass into linq query
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate (string s) { return s; };

            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var item in subset)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.WriteLine();
        }

        private class VeryComplexQueryExpression
        {
            internal static void QueryStringWithRawDelegates()
            {
                Console.WriteLine("**** Using Raw Delegates *****");

                string[] currentVideoGames = { "Marrowind", "Uncahrted 2", "Fallout 3", "Daxter", "System Shock 2" };

                //creating func delegates that point to matching methods to pass them into a linq query  
                Func<string, bool> searchFilter = new Func<string, bool>(filter);
                Func<string, string> itemToProcess = new Func<string, string>(processItem);

                var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);
                foreach (var item in subset)
                {
                    Console.WriteLine($"item: {item}");
                }
                Console.WriteLine();
            }

            public static bool filter(string game) { return game.Contains(" "); }
            public static string processItem(string game) { return game; }
        }
    }
}
