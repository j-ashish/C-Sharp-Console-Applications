using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while loop is the loop which is executed once no matter the conditionm is true or false. Because the while clause or the condition statement is defined after the do loop, so it given the loop flexibilty of runnin once.
            int index = 1;

            do // Do this code
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 10); // While this condition is true.
        }
    }
}
