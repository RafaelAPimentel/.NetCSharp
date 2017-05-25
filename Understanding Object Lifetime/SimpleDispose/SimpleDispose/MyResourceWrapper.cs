using System;

namespace SimpleDispose
{
    internal class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("******* In Dispose *****");
        }
    }
}