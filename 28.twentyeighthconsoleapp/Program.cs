using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Static methods are the methods that are associated with the classes not the objects. For example:- 
            Console.WriteLine(Math.Sqrt(144)); // Here we have the method called Sqrt(); which is in the Class called Math.

            // But we are not calling this Sqrt method by creating an instance. Like: Math mymath = new Math();. We are just calling it directly just calling the Class and then the method. These are the methods that are called static methods. These methods doesn't need recognition of an instance, it can directly called by the class.

            // Here we defined this function in a class named UsefulTools SayHi, which is a class method. This method doesn't need an instance to run it can be directly called with the class, because it is a class's method not objects.
            UsefulTools.SayHi("Ashish Jain");
            


            

            



        }
    }
}
