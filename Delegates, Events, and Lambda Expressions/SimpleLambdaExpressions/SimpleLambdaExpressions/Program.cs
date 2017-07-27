using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Lambdas ****\n");
            TriaditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();
            Console.Read();
        }

        private static void LambdaExpressionSyntax()
        {
            //Make a list 
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20,1,4,8,9,44});

            Console.WriteLine("Here are your even numbers using the lambda expression:");
            //Now use a C# lambda expression
            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine($"value of i is currently: {i}");
                bool isBool = (i % 2) == 0;
                return isBool;
            });


            foreach (var evenNumber in evenNumbers)
                Console.Write($"{evenNumber} \t");
        }

        private static void AnonymousMethodSyntax()
        {
            //Make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20,1,4,8,9,44});

            //now use the anonymous method
            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

            
            //here are your even numbers
            Console.WriteLine("Here are your even numbers using the anonymous methods \n");
            foreach (var evennumber in evenNumbers)
            {
                Console.Write($"{evennumber} \t");
            }

  
            Console.WriteLine();
        }

        private static void TriaditionalDelegateSyntax()
        {
            //Make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //Call FindAll() using traditional delegate syntax
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            //UNCOMMENT TO SEE OUTPUT FOR THIS METHOD
            Console.WriteLine("Here are your even numbers the traditional way");
            foreach (var evennumber in evenNumbers)
            {
                Console.Write($"{evennumber} \t");
            }
            Console.WriteLine();
        }

        //target for the predicate delegate
        private static bool IsEvenNumber(int obj)
        {
            //is it an even number
            return (obj % 2) == 0;
        }
    }
}
