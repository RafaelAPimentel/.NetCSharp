using System;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IBasicMath
    {
        public int Add(int valueOne, int valueTwo)
        {
            //Simulate a lengthy request
            System.Threading.Thread.Sleep(1000);
            return valueOne + valueTwo;
        }
    }
}
