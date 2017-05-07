using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged Multidimensional Array");
            int[][] jagged = new int[5][];

            //creating jagged array
            for (int i = 0; i < jagged.Length; i++)
                jagged[i] = new int[i + 5];

            //print each row
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=>Rectangular Multidimensional Array");
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            //Populate 3*4 array
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            //print multi array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i,j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
    
        }

        static void printArray(int[] myInts)
        {
            Console.WriteLine("array contains");
            foreach(int i in myInts)
                Console.Write("{0} \t",i);
        }

        static string[] GetStringArray()
        {
            string[] StrArr = { "hello", "from", "the", "other", "side" };

            return StrArr;
        }

        static void PassAndReceiveArray()
        {
            int[] myInt = { 1, 2, 3, 4, 5 };
            printArray(myInt);

            string[] getString = GetStringArray();
            Console.WriteLine(string.Join(" ", getString));
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with system.Array.");
            //initialize the array
            string[] gothicBand = { "Tones on tails"," Bauhaus","Sisters of Mercy"};

            //order of initialization
            Console.WriteLine("-> array in regular order");
            foreach(string str in gothicBand)
                Console.Write(str + ", ");
            Console.WriteLine("\n");

            //reversing the order of array
            Array.Reverse(gothicBand);
            Console.WriteLine("-> Array reversed ordered");
            foreach(string str in gothicBand)
                Console.Write(str + ", ");
            Console.WriteLine("\n");

            //clearing out array
            Array.Clear(gothicBand,0,gothicBand.Length);
            foreach(string str in gothicBand)
                Console.Write(str + " ");
            Console.WriteLine("array has been cleared!!!");

        }
        static void Main(string[] args)
        {
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArray();
            SystemArrayFunctionality();
            Console.ReadKey();
        }
    }
}
