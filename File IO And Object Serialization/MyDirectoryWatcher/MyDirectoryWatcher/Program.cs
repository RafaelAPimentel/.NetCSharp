using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDirectoryWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** The Amazing File Watcher App ****\n");
            //Establish the path to the directory to watch 
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @".\MyFolder";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            //Set up the things to be on the lookout for
            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //only watch text files
            watcher.Filter = "*.txt";

            //Add eventhandlers
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            //bBegin watching the directory
            watcher.EnableRaisingEvents = true;

            //Wait for the user to quit the program
            Console.WriteLine(@"Press 'q' to quit app.");
            while (Console.Read() != 'q')
                ;
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File: {e.OldFullPath} renamed to  {e.FullPath}");
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }
    }
}
