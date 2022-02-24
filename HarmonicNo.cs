using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class Harmonic
    {
        public static void harmonicFunction()

        {
            Console.WriteLine("Enter a number:");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            double x = 0.0;

            for (double i = 1; i < n; i++)
            {
                x = x + 1 / i;
            }
            Console.WriteLine(x + " is harmonic value");
        }

    }
}
