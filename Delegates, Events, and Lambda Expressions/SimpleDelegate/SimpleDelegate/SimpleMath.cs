using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class SimpleMath
    {

        //This class contains method BinaryOp 
        //can point to
        public int Add(int x, int y) { return x + y; }
        public int Subtract(int x, int y) { return x - y; }
        public static int Squarenumber(int x) { return x * x; }
    }
}
