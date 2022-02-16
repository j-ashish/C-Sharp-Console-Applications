using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop, loops through the code until the condition provided in while loop is true it is also referred as infinte loop.

            int index = 1;          // Here we assign the value 1 to the index variable.
            while (index <= 10) // this means: loop certain code until this condition is true. 
            {
                Console.WriteLine(index);// When it is looping we are checking the what the index value after loop everytime.
                index++; // To terminate this loop and to stop the progam to run infinte number of times we are increasing the value. When the index value pass the number 10 condition will become false and while loop will be terminated.
            }

        }
    }
}
