using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettinguserinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine(); // Console.ReadLine is used to retrive the value from the user, but it always return the string value.
            Console.Write("What Is Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello "+name.ToUpperInvariant());
            Console.WriteLine("Your Age Is: "+age);



        }
    }
}
