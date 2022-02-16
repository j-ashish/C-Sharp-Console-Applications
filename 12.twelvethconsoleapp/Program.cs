using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If statement works on the boolean fundamentals which are if true do this if not do this. For this we created a variable which store a boolean value. If the condition is true it will return something and if it is not true means false it will return another clause which is the else caluse which will only return when all conditions fails to prove.
            // Basic syntax is if (conditions){code to be executed}

            bool isMale = false;
            if (isMale)
            {
                Console.WriteLine("You are Male");
            }
            else
            {
                Console.WriteLine("You are not Male");
            }


            bool isMalee = true;
            bool isTall = true;
            if (isMalee && isTall) // Here we defined two conditions together (&& - and) 'and' operator check and passes when the both conditions are true. If any one condition is false, this condition will fail.
            {
                Console.WriteLine("You are a Tall male");
            }
            else
            {
                Console.WriteLine("You are not Male or not Tall or both");
            }


            bool isMaLe = false;
            bool isTAll = true;
            if (isMaLe || isTAll) // Here we defined two conditions together (|| - or) 'or' operator check and passes when one of the definde condition is true. If the one or both conditions are true it passes, but if only both are false it will fail.
            {
                Console.WriteLine("You are a male or you are tall");
            }
            else
            {
                Console.WriteLine("You are not Male and notTall");
            }

            bool isMALE = false;
            bool isTALL = true;
            if (isMALE && isTALL) // Here we defined two conditions together (&& - and) 'and' operator check and passes when the both conditions are true. If any one condition is false, this condition will fail.
            {
                Console.WriteLine("You are a Tall male");
            }
            else if (isMALE && !isTALL) // This time we used else if which is added when there are so many conditions to check if the if condition will fail this will be checked if this gets fail then the else will be executed. ! this is the sign of not, it turn the conditions to true if false and true to false. We can add more than one else if conditions.
            {
                Console.WriteLine("You are Male but not Tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }


        }
    }
}
