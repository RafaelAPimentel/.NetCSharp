using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    internal class SportsCar
    {
        public SportsCar()
        {
            //Get context information and print out context ID.
            Context ctx = Thread.CurrentContext;
            System.Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
            {
                System.Console.WriteLine($"-> Ctx Prop: {itfCtxProp.Name}");
            }
        }
    }
}