using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_of_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Now that we have created the constructor we can create the objects with passing the values direct in the constructor
            // We have to pass them poistionally and with exact data type.

            Book book1 = new Book("HarrY Potter", "J.K. Rowling", 400);
            Book book2 = new Book("Learning Python", "Mark Lutz", 1600);
            // Now that we have created instances we can call this objects or see the values as we saw before (Dot notation).

            Console.WriteLine($"BOOK TITLE {book1.title} \t BOOK AUTHOR {book1.author} \t BOOK PAGES {book1.pages}");
            Console.WriteLine($"BOOK TITLE {book2.title} \t BOOK AUTHOR {book2.author} \t BOOK PAGES {book2.pages}");

            


        }
    }
}
