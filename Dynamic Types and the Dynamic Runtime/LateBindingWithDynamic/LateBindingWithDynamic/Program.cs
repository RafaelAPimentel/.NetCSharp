using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AddWithDynamic();
            Console.Read();
        }
        static void AddWithDynamic() {
            Assembly asm = Assembly.Load("MathLibrary");

            try
            {
                //Get metadata for the SimpleMath type
                Type math = asm.GetType("MathLibrary.SimpleMath");

                //Craete a simpleMath on the fly
                dynamic obj = Activator.CreateInstance(math);

                //Note how easy we can now call Add()
                Console.WriteLine($"Result is: {obj.Add(10,70)}");
            }
            catch(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void addWithReflection() {

            Assembly asm = Assembly.Load("MathLibrary");

            try
            {
                //Get metadata for the SimpleMath type
                Type math = asm.GetType("MathLibrary.SimpleMath");

                //create simple math on the fly
                object obj = Activator.CreateInstance(math);

                //get info for add
                MethodInfo mi = math.GetMethod("Add");
                
                //getmethod (with parameter)
                object[] args = { 10,70};

                //Note how easy we can now call Add()
                Console.WriteLine($"Result is: {mi.Invoke(obj ,args)}");
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
