using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMax(20,10));
            Console.WriteLine(GetMax(20, 10 , 30));
        // In this example we use conditional operators which are : > , < , >= , <= , != , ==


        }

        // Here we created a method that return the greatest value when passed two values. We used if else condition to determine which value is greater.
        static int GetMax(int num1 , int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        // This time we passed three arguments and check which value is biggest.
        static int GetMax(int num1, int num2 , int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}
