using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Directory(Info) ****");
            ShowWindowsDirectoryInfo();
            DisplayBMPFiles();
            ModifyAppDirectory();
            Console.Read();
        }

        private static void ShowWindowsDirectoryInfo()
        {
            //Dump directory information
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine($"FullName: {dir.FullName}");
            Console.WriteLine($"Name: {dir.Name}");
            Console.WriteLine($"Parent: {dir.Parent}");
            Console.WriteLine($"Creation: {dir.CreationTime}");
            Console.WriteLine($"Attribute: {dir.Attributes}");
            Console.WriteLine($"Root: {dir.Root}");
            Console.WriteLine($"*****************************");
        }

        static void DisplayBMPFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\rafyr\Pictures");
            //Get all files with a *.bmp extension
            //FileInfo[] bmpFiles = dir.GetFiles("*.bmp", SearchOption.AllDirectories);
           FileInfo[] bmpFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            //How mamny were found
            Console.WriteLine($"found {bmpFiles.Length}");

            foreach (FileInfo f in bmpFiles)
            {
                Console.WriteLine("************************");
                Console.WriteLine($"File name:  {f.Name}");
                Console.WriteLine($"File size: {f.Length}");
                Console.WriteLine($"Creation: {f.CreationTime}");
                Console.WriteLine($"Attribute: {f.Attributes}");
                Console.WriteLine("***********************");
            }
        }

        static void ModifyAppDirectory() {
            DirectoryInfo dir = new DirectoryInfo(@".");
            //Create \MyFolder off application directory
            dir.CreateSubdirectory("MyFolder");

            //Create \MyFolder\Data off application dir
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"Myfolder2\Data");

            //Prints path to ...\MyFolder2\Data
            Console.WriteLine($"New Folder is: {myDataFolder}");
        }

        static void FunWithDirectoryType() {
            //List all drivers on current computer
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine($"Here are yoru drives:");
            foreach (string  s in drives)
            {
                Console.WriteLine(  $"-->{s}");
            }

            //Delete what was created
            Console.WriteLine("Press Enter to delete directories");
            Console.Read();
            try
            {
                Directory.Delete(@"C:\MyFolder");

                //the second parameter specifies whether you 
                //wish to destroy any subdirectories.
                Directory.Delete(@"C:\MyFolder2\Data",true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


