using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeFactors
    {
        public static void FindPrimeFactors()
        {
            int a, b, flag = 0;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 2; b < a; b++)
            {
                if (a % b == 0)
                {
                    for (int i = 2; i < b; i++)
                    {
                        if (b % i == 0)
                        {
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 0)
                        Console.WriteLine(b);
                }
            }
        }
    }
}
