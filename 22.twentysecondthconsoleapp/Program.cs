using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // We are dividing tow numbers, but when the exception is going to occur when user divide a number by zero or it enters a string.

            Console.Write("Enter A Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);


            // To stop the program being disturbed by the errors or bugs or exception we are going to use try catch statements. In try statement we put the code which we find that may cause an error during runtime and catch clause catches the error and prevent the program to throw an exceptions.


            int numm;
            int numm2;

            try
            {
                Console.Write("Enter A Number: ");
                numm = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter A Number: ");
                numm2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numm / numm2);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You can't divide an integer with zero");
            }
            catch (Exception e) // Exception is a pre-defind and we are assigning it's value in the e.
            {
                Console.WriteLine("Error"); // Besides showing error to the user it will show this statement.
                Console.WriteLine(e.Message); // This is also a method to tell the user what went wrong when you are not sure what errors your program can possibly cause. 
            // We can declare as many catch block with exceptions that we can think of, that can possibly go wrong.
            }
            finally
            {
                // This block is used when we want to do something no matter how the program behaves. This clause will be executed no matter error happens or not.
                Console.WriteLine("This will happen no matter how the program works");
            }



        }
    }
}
