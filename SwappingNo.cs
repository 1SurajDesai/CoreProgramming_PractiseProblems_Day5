using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwappingNo
    {
        public static void SwapTwoNo()
        { 
            int a = 5, b = 10;
            Console.WriteLine("Before swapping: a={0} and b={1}", a,b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swapping: a={0} and b={1}", a, b);
        }
    }
}
