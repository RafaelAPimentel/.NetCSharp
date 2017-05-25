using System;

namespace SimpleFinalize
{
    public class MyResourceWrapper
    {
         ~MyResourceWrapper()
        {
            //Clean up unmanaged resources here

            //Beep when destroyed
            Console.Beep();
        }
    }
}