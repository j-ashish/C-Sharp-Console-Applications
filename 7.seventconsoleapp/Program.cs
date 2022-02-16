using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // Convert is used to change the data type of an object, it is not only limited to int, it can be any datatype until it's valid.
            Console.Write("Enter Another Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);




        }
    }
}
