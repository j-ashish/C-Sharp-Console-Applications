using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_classes
{
    // Now if we make a class static it's solely purpose is to user let use it's methods(functions) but stop user to make or create new instances.
    static class UsefulTools
    {

         public static string SayHi(string name)
        {
            string prompt = "Hello " + name;
            return prompt;
        }


        // Now we created the method that returns a string and takes string as an argument.

    }
}
