using System;
using System.Threading;
using MathClient.ServiceReference1;

namespace MathClient
{
    public static class Program
    {
        //you will have to create the MathServiceLibrary because I removed it.
        //use installutil MathWinServiceHost.exe to install 
        //in the MathWinService debug directory
        //uninstall using installutil /u MathWinServiceHost.exe 
        //in same directory
        private static void Main()
        {
            Console.WriteLine("**** The Async Math Client ****");
            Console.WriteLine("Enter a number..");
            var num1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter another number..");
            var num2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            using (var proxy = new BasicMathClient())
            {
                proxy.Open();

                //Add numbers in an async manner,using a lambda expression.
                IAsyncResult result = proxy.BeginAdd(num1, num2,
                    ar => { Console.WriteLine($"{num1} + {num2} = {proxy.EndAdd(ar)}"); }, null);
                while (!result.IsCompleted)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Console wroking..");
                }
            }
            Console.ReadLine();
        }
    }
}
