using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with FileStreams ****");

            //Obtain a filestream object
            using (FileStream fStream = File.Open(@".\myMessage.dat", FileMode.Create))
            {
                //Encoding a string as an arrayr of bytes.
                string msg = "Hello";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                //write byte[] to file
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                //Reset internal position of stream
                fStream.Position = 0;

                //Read the types from file and display to console
                Console.WriteLine("Your message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();                    
                    Console.WriteLine(bytesFromFile[i]);
                }

                //display decoded message
                Console.Write("\nDecoded message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
                Console.Read();
            }
        }
    }
}
