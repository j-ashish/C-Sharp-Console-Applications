using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace better_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // In this program we are asking for values from user and we are going to calculate the value according to their command. We used if and else to determine the operator.

            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator");
            string op = Console.ReadLine();

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

        }
    
    }

}
