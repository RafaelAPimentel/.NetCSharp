using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Custom AppDomains ****");
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
            {
                Console.WriteLine("Default AD Unloaded");
            };

            ListAllAssembliesInAppDomain(defaultAD);
            //Make a new App Domain
            MakeNewAppDomain();
            Console.Read();
        }

        private static void MakeNewAppDomain()
        {
            //Make  a new AppDomain in the current process and
            //list oaded assemblies
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");
            newAD.DomainUnload += (o, s) =>
            {
                Console.WriteLine($"The second AppDomain has been unloaded");
            };

            try
            {
                newAD.Load("CarLibrary");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            ListAllAssembliesInAppDomain(newAD);
            AppDomain.Unload(newAD);
        }

        private static void ListAllAssembliesInAppDomain(AppDomain defaultAD)
        {
            //Now get all loaded assemblies in the default AppDomain
            var loadedAssemblies = from a in defaultAD.GetAssemblies() orderby a.GetName().Name select a;
            Console.WriteLine($"***** Here are the assemblies loaded in {defaultAD.FriendlyName}*****");
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"->Name: {a.GetName().Name}");
                Console.WriteLine($"-> Version: {a.GetName().Version}");
            }
        }
    }
}
