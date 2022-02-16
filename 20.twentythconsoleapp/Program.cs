using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exponent_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPow(2,10));
        }
        // We created here the function which return the exponent value by looping over the value until the condition gets false.
        // We are multiplying the number itself, times the second number.

        static int GetPow(int basenum , int pownum)
        {
            int result = 1;

            for (int i = 0; i < pownum; i++)
            {
                result = result * basenum;
            }
            
            return result;
        }


    }
}
