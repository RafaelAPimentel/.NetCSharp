using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    [Synchronization]
    internal class SportsCarTS : ContextBoundObject
    {
        public SportsCarTS()
        {
            //Get context information and print out context ID.
            Context ctx = Thread.CurrentContext;
            Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
            {
                Console.WriteLine($"-> Ctx Prop: {itfCtxProp.Name}");
            } 
        }
    }
}