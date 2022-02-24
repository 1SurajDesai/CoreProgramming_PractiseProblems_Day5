using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FindLargestNo
    {
        public static void FindLargestNumber()
        { 
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three numbers");
            Console.WriteLine("Enter a first no:");
            num1 =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second no:");
            num2  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third no:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("{0} is greater amonge three numbers", num1);
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("{0} is greater amonge three numbers", num2);
            else
                Console.WriteLine("{0} is greater amonge three numbers", num3);
        }
    }
}
