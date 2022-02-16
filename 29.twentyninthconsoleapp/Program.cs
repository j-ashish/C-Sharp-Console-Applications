using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Like static methods in an class we can solely create a class that only constains methods that are consists of these methods. Whose solely purpose is to provide methods that are useful but can't create instances.

            // Example: Math myMath = new Math(); ... Like this class we are not allowed to create instances of these classes these class are only there for a solely purpose, which is providing some useful method that can take values and returns values, but don't let create instances.

            // Now we created a class named UsefulTools that contains a value and that class and method solely purpose is to use them and we can't make changes or create instances of this class.

            //UsefulTools use = new UsefulTools();  we are trying to make this instance but it is stopping us to create instance because it's solely purpose is to provide methods.
            Console.WriteLine(UsefulTools.SayHi("Ashish Jain"));



        }
    }
}
