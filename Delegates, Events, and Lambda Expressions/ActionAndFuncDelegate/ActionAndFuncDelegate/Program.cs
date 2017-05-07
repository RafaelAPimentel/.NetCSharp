using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Action Func ****");

            //use the action delegate to point to the DisplayMessage
            //Action can only point to something that returns void
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);

            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            //Func delegate are pointers to functions that return anything other than void
            //the last parameter is the return type
            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine($"40 + 40 = {result}");

            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount) {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            //restore color
            Console.ForegroundColor = previous;
        }
        static int Add(int x, int y) {
            return x + y;
        }

        static string SumToString(int x ,int y) {
            return (x+y).ToString();
        }
    }
}
