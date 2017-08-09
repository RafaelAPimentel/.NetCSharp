using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Binary Writer / Reader ****");

            //Open a binary writer for a file
            FileInfo f = new FileInfo("BinFile.dat");
            using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                //Print out the type of BaseStream
                Console.WriteLine($"Base stream is: {bw.BaseStream}");

                //Create some data to save in the file
                double aDouble = 1234.67;
                int anInt = 34567;
                string aString = "A, B, C";

                //write the data
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
            }

            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                Console.WriteLine($"Directory: {f.FullName}");
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
