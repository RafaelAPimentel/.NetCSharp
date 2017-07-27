using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with the Default AppDomain ****");
            //DisplayDADStats();
            //ListAllAssembliesInAppDomain();
            InitDAD();
            Console.Read();
        }
        private static void InitDAD() {
            //This logic will print ut the name of any assembly
            //loaded into the application domain, after it has been 
            //created
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) => { Console.WriteLine($"{s.LoadedAssembly.GetName().Name} has been loaded"); };
        }
        private static void ListAllAssembliesInAppDomain() {
            //Get access to the AppDomain for the current thread
            AppDomain defaultAD = AppDomain.CurrentDomain;

            //Now get all loaded assemblies in the default AppDomain
            var loadedAssemblies = from  a in defaultAD.GetAssemblies() orderby a.GetName().Name select a;
            Console.WriteLine($"**** Here are the assemblies loaded in {defaultAD.FriendlyName} ****");
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name: {a.GetName().Name}");
                Console.WriteLine($"->Version: {a.GetName().Version}");
            }
        }
        private static void DisplayDADStats()
        {
            //Get acces to the appDomain for the current thread.
            AppDomain defaultAD = AppDomain.CurrentDomain;

            //print out various stats about this domain
            Console.WriteLine($"Name of this Domain: { defaultAD.FriendlyName}");
            Console.WriteLine($"ID of domain in this process: {defaultAD.Id}");
            Console.WriteLine($"Is this the default domain? : {defaultAD.IsDefaultAppDomain()}");
            Console.WriteLine($"Base directory of this domain: {defaultAD.BaseDirectory}");
        }
    }
}
