using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class PowerOftwo
    {
        public static void powerFunction()
        {
            int N;
            int i = 0;
            string n;

            Console.WriteLine("Enter  a number");
            n = Console.ReadLine();
            N = Convert.ToInt32(n);

            if (N < 0 && N > 31)
            {
                Console.WriteLine(" Enter a valid number");

            }
            else
            {

                while ((Math.Pow(i, 2) <= Math.Pow(2, N)) && i <= N)
                {
                    Console.WriteLine("{0} ^ 2 = {1}", i, Math.Pow(i, 2));
                    i++;
                }
            }

        }
    }
}
