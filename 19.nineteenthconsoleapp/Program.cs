using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop are used when the value is determined or defined, and we have to run that loop for the finite number of times to get to the value.

            // for loop construction consist of three basice thing, first initializing a variable, second providing a condition , third increament of variable (times the loop will run).
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            int[] luckyNumbers = { 10, 20, 30, 40, 50, 60, 70 };

            // We can access the each value inside the array.

            for (int j = 0; j < luckyNumbers.Length; j++) // We are giving condition according to the length of the array.
            {
                Console.WriteLine($"Array number {j+1} {luckyNumbers[j]}"); // Here we are accessing the array with it's index value.
            }

        }
    }
}
