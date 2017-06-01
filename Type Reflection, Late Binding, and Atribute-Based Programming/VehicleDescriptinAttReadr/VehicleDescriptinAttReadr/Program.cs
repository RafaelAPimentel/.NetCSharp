using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributedCarLibrary;
using System.Reflection;

namespace VehicleDescriptinAttReadr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Value of VehicleDescriptionAttribute ****");
            ReflectOnAttributeUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributeUsingEarlyBinding()
        {
            
            try
            {
                //Load local assembly
                Assembly asm = Assembly.Load("AttributedCarLibrary");

                //get Type info of VehicleDescriptionAttribute
                Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");

                //get type info of the description property
                PropertyInfo propDesc = vehicleDesc.GetProperty("Description");

                //get all types in the assembly
                Type[] types = asm.GetTypes();

                //iterate over each type and obtain and VehicleDescriptionAttributes.
                foreach (Type t in types)
                {
                    object[] objs = t.GetCustomAttributes(vehicleDesc, false);

                    //Iterate over each VehicleDescriptionattribute and prin
                    //the description s=using late binding
                    foreach (object  o in objs)
                    {
                        Console.WriteLine($"->{t.Name}: {propDesc.GetValue(o,null)}");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
