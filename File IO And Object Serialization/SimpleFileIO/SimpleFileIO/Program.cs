using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfoCreate();
            //FileInfoOpen();
            Console.WriteLine("**** Simple IO with the File Type ****");
            string[] myTask = { "Fix the bathroom sink", "Call Dave", "Call Mom and Dad", "Play Xbox One" };

            //Write out all data to file
            File.WriteAllLines(@".\task.txt", myTask);

            //Read it all back and print out
            foreach (string task in File.ReadAllLines(@".\task.txt"))
            {
                Console.WriteLine($"TODO: {task}");
            }
            Console.ReadLine();
        }

        static void FileInfoCreate()
        {
            //Make a new file a scope fo rfile IO
            //types is ideal
            FileInfo f = new FileInfo(@".\Test.txt");
            using (FileStream fs = f.Create())
            {
                //use the filestream
            }
        }

        static void FileInfoOpen() {
            //Make a new file via fileinfo.open
            FileInfo f2 = new FileInfo(@".\Test2.txt");
            using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None))
            {
                //use the file stream object....
            }
        }

        static void FileInfoOpenRead() {
            //Get a FileStream object with a read-only permission
            FileInfo f3 = new FileInfo(@".\Test");
            using (FileStream readOnlyStream = f3.OpenRead())
            {
                //use the filestream object
            }

            //Now get a filestream object with write-only permissions.
            FileInfo f4 = new FileInfo(@".\Test");
            using (FileStream writeOnlyStream = f4.OpenWrite())
            {
                //use the filestream object
            }
        }

        static void FileInfoOpenText() {
            //Get a StreamReader object
            FileInfo f5 = new FileInfo(@".\Test");
            using (StreamReader sreader = f5.OpenText())
            {
                //use the streamreader object
            }
        }
    }
}
