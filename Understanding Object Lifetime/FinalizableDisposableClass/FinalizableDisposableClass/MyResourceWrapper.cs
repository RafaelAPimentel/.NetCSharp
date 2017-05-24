using System;

namespace FinalizableDisposableClass
{
    internal class MyResourceWrapper : IDisposable
    {
        //Used to determine if Dispose()
        //has already been called.
        private bool disposed = false;

        public void Dispose()
        {
            //Call the helper method
            //Specifying "true" signifies that
            //the object user triggers the cleanup.
            CleanUp(true);

            //Now suppress finalize
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool v)
        {
            //Be sure we have not already been disposed!
            if (!this.disposed)
            {
                //if disposed equals true, dispose all
                //managed resources
                if (disposed)
                {
                    //Dispose managed resources
                }
                //Clean up unmanged seources here
            }
            disposed = false;
        }

        //Garbage collector will call this method is te objectuser forgets to call Dispose()
        ~MyResourceWrapper(){
            Console.Beep();

            //Clean up any internal nmanaged resources.
            //Do **not** call Dispose() on any managed objects.
            CleanUp(false);
        }

        //The object user will call this method to clean up 
        //resources ASAP.

    }
}