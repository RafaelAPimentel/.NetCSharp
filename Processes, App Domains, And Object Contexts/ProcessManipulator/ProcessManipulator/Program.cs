using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessManipulator
{
    class Program
    {
        static void ListAllRunningProcess() {
            //Get all the processes on the local machine, ordered by
            //PID
            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;

            //print out PIDand name of each process
            foreach (var p in runningProcs)
            {
                string info = string.Format($"->{p.Id}\t Name:{p.ProcessName}");
                Console.WriteLine(info);
            }
            Console.WriteLine("******************************");
        }

        static void GetSpecificProcess() {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(27028);
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void EnumModsForPid(int pID) {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(27028);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Here are the loaded modules for: {theProc.ProcessName}");
            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                string info = string.Format($"->Mod Name: {pm.ModuleName}");
                Console.WriteLine(info);
            }
        }
        static void StartAndKillProcess() {
            Process GCProc = null;
            try
            {
                GCProc = Process.Start("Chrome.exe", "www.facebook.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
     
            }
            Console.Read();
            try
            {
                GCProc.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Processes");
            //ListAllRunningProcess();
            //GetSpecificProcess();
            //EnumModsForPid(840);
            StartAndKillProcess();
            Console.Read();
        }
    }
}
