using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingwithnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(5 + 8); // adding two numbers
            Console.WriteLine(8 - 5); // subtracting two numbers
            Console.WriteLine(5 * 8); // multipying two numbers
            Console.WriteLine(5 / 8); // dividing two numbers
            Console.WriteLine(5 % 2); // modulo operator is used to get the remainder of the values.

            Console.WriteLine(4 + 2 * 3); // Here is the example of the precedence, according to it some operators are considered before some other operators.
            int num = 6;
            num--; // This will reduce the 1 number down 
            num++; // this will add 1 number up.

            //  Maths functions
            Console.WriteLine(Math.Abs(-40)); // return absolute value of any number.
            Console.WriteLine(Math.Pow(3,2)); // it return the exponential value of 3 * 3.
            Console.WriteLine(Math.Sqrt(36)); // return the square root of the given value.
            Console.WriteLine(Math.Max(40,50)); // returns the maximum value between given value
            Console.WriteLine(Math.Min(40,50)); // rerurns the minimum value between given value.
            Console.WriteLine(Math.Round(40.33)); // rounds the value to the closest rounded value.




        }
    }
}
