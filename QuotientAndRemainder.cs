﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
     class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            int dividend, divisor;
            Console.WriteLine("Enter a dividend:");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("remainer: " + remainder);


        }
    }
}
