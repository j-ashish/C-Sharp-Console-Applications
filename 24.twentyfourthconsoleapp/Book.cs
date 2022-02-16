using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_of_classes
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        // To create a constructor we have to name it as same as the name of the class.
        // we can pass parameters inside the constructor to access the attributes of our class.
        public Book(string book_name , string book_author , int book_pages)
        {
            this.title = book_name;
            this.author = book_author;
            this.pages = book_pages;
        }


    }
}
