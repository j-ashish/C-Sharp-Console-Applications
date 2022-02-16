using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating); // getter let us access the attribute. (AUDIT)

            
            avengers.Rating = "This"; // setter let us change the value but with certain conditions, here we didn't match up with setter conditions it set the value to some default value.
            Console.WriteLine(avengers.Rating);



            avengers.Rating = "PG"; // Here we change the value as per setter condition.
            Console.WriteLine(avengers.Rating);


            Movie spider = new Movie("Spider Man", "Stan Lee", "Anyone"); // Now that we have set the rating as per method we can't put anything in the rating, we have to go through certain conditions, if not setter will set some default value.
            Console.WriteLine(spider.Rating);  // here we are not as per setter standards so we get the default value.

        }
    }
}
