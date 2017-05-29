using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Late Binding****");
            //try to load a local copy of CarLibrary
            //use LoadFrom and use path to find the dll that you are looking for
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (a != null) {
                CreateUsingLateBinding(a);
                InvokeMethodWithArgsUsingLateBinding(a);
            }
            Console.Read();
        }

        static void CreateUsingLateBinding(Assembly asm) {
            try
            {
                //Get metadata for the minivan type
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                //create a minican instance on the fly
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine($"Created a {obj} using late binding");

                //Get info for TurboBoost
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                //invoke method using null for no parameters
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InvokeMethodWithArgsUsingLateBinding(Assembly asm) {
            try
            {
                Type sport = asm.GetType("CarLibrary.SportsCar");
                //now create the sports car
                object obj = Activator.CreateInstance(sport);

                //invoke turnonRadio with arguments
                MethodInfo mi = sport.GetMethod("TurnOnRadio");
                mi.Invoke(obj, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
