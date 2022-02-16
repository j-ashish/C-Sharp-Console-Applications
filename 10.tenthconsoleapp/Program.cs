using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi(); // To use the method we have to use inside the main method. The way we have to use is the name of the method and then open and closed paranthese and then traditional colon. Now we called our created method inside the main method or inside the working window.
            SayHii("Ashish"); // Here we call it like before, but just the diffrence is we are passing an argument inside the function which is an string.

            // We are not bounded to call these functions only once, we can call them as many time as we want them to use.

            SayHi();
            SayHi();
            SayHii("Ashu");
            SayHii("Jenny");


            // To use these methods we have to be focused when we are passing the values inside them, we have to pass the arguments as the way they are defined and the datatype is used to define them. Taking this example into consideration, we passed positional arguments first string and then integer. And we are seperating the values with comma.
            SayHiii("Ashish", 22);

        }
        // Methods are defined outside the main methods and inside the main class. I mean here:-

        //This is the the basic syntax to create method, that doesn't return any value:-
        static void SayHi() // SayHi is here is the method name we are going to create and use. After that we have to put the code inside the curly brackets.
        {
            // When we say void while defining the method, it basiclly means that it ain't gonna return anything. Return here means manupulated data.
            
            Console.WriteLine("Hi User...!!!");
        }

        // This is the method we are passing some kind of arguments, so the method will display the custom message. It still isn't returning the value.
        static void SayHii(string name) // Now we are passing the string as a parameter. And we bound this method to take an argument which must be string.
        {
            Console.WriteLine("Hello "+name); // Here method takes the value and creates the custom message.
        }

        // In this method now we are passing two arguments with two diffrent datatypes.
        static void SayHiii(string name , int age)
        {
            Console.WriteLine("Hello "+name+" with age "+age); // now we are getting two values.
        }

    }
}
