using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelConstant
    {
        public static void CheckVowelConstant()
        {
            Console.WriteLine("Enter a character");
            String str = Console.ReadLine().ToLower();
            char ch = Convert.ToChar(str);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == '0' || ch == 'u')
            {
                Console.WriteLine("Its a Vowel");
            }
            else
            {
                Console.WriteLine("Its a Constant");
            }
        }
    }
}
