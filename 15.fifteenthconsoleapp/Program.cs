using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch case statements are useful to write short conditional statements. If else is a lengthy process and it is used for complicated processes, but switch statements are useful for less complicated conditional statements.

            string dayval = GetDay(10);
            Console.WriteLine(dayval);

        }

        static string GetDay(int daynum)
        {
            string dayname;

            switch (daynum) // In parantheses we check the condition.
            {
                case 0 :      // in case we check is there the value inside switch matches this value, if not move on.
                    dayname = "Sunday";
                    break;      // Break is used to exit the statement, if the statement or in this example case is true exit this statement quickly.
                case 1 :
                    dayname = "Monday";
                    break;
                case 2:
                    dayname = "Tuesday";
                    break;
                case 3 :
                    dayname = "Wednesday";
                    break;
                case 4 :
                    dayname = "Thursday";
                    break;
                case 5:
                    dayname = "Friday";
                    break;
                case 6:
                    dayname = "Saturday";
                    break;
                default:        // Default is used to put something if the value in condition doesn't match case statements. And beside throwing errors and exceptions it returns error with value, which doesn't interupt the program.
                    dayname = "Invalid";
                    break;
            }
            return dayname;
        }
    }
}
