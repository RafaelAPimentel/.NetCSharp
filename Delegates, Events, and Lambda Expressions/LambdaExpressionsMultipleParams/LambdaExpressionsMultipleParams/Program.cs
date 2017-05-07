using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        public delegate string VerySimpleDelegate();
        static void Main(string[] args)
        {
            VerySimpleDelegate d = new VerySimpleDelegate(()=> { return "Enjoy your string"; });
            //Register with delegate as a lambda expression
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine($"Message {msg}, Result: {result}");
            });

            //This will execute the lambda expression
            m.Add(10, 10);
            Console.WriteLine(d());
            Console.Read();
            
        }
    }
}
