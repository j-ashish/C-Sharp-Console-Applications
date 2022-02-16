using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cubed_num = Cube(2); // Now that we know that this function returns value so we have to store this value inside the variable which should be as same as the return value, in this context it is integer or int.
            Console.WriteLine(cubed_num); // Now we are printing the return value.


            Console.WriteLine(Cube(5));  // We are Calling the function inside the print statement and we can get the statement this way too, but we are not storing this value in an variable.


        }
        
        // Now this time we are specifing the value we want to return by providing the detail or datatype after static, in this case which is int.
        static int Cube(int num)
        {
            int result = num * num * num; // Here we performed the function with value in the parameter.
            return result; // And we use special keyword that returns the given value of result as a return value.
        }

    }
}
