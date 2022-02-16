using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First to use the class we have to use and declare that class in a variable. We can create as much as object we want.

            Book book1 = new Book(); // Here we are declaring the book object. Now we can use it's functionality to grow our program.
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Learning Python";
            book2.author = "Mark Lutz";
            book2.pages = 1600;

            Console.WriteLine($"BOOK TITLE {book1.title} \t BOOK AUTHOR {book1.author} \t BOOK PAGES {book1.pages}");
            Console.WriteLine($"BOOK TITLE {book2.title} \t BOOK AUTHOR {book2.author} \t BOOK PAGES {book2.pages}");

        }
    }
}
