using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with DriveInfo ****");

            //get info regarding all drives.
            DriveInfo[] myDrives = DriveInfo.GetDrives();

            //Now print drive state
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Type: {d.DriveType}");

                //check to see if the drive is mounted
                if (d.IsReady) {
                    Console.WriteLine($"Free space: {d.TotalFreeSpace}");
                    Console.WriteLine($"Format: {d.DriveFormat}");
                    Console.WriteLine($"Label: {d.VolumeLabel}");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
