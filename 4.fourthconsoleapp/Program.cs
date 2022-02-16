using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingwithstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ashish Jain"); //plain text
            Console.WriteLine("Ashish \n Jain"); // \n is a escape sequence which is used to tell the compiler that after that create a new line
            Console.WriteLine("Ashish \" Jain"); // \" is used to avoide the quotation marks error which can create by adding quotation marks in between the string.
            string phrase = "Ashish Jain";
            Console.WriteLine(phrase); // printing the value to the console through the variable.
            string phrase2 = "Ashish" + "Jain"; // adding the + in between string concatnate them or add them together.
            Console.WriteLine(phrase.Length); // Length is the special keyword for strings that return the length of the string in the integer.
            Console.WriteLine(phrase.ToUpper()); // ToUpper method is used to make the string in all uppercase.
            Console.WriteLine(phrase.ToLower()); // ToLower method is used to make the string in all lower case.
            Console.WriteLine(phrase.Contains("Jain")); // Contains method want a value as a parameter to find that certain value if that exist in the string it will return true or it will return false. 
            Console.WriteLine(phrase[0]); // this method want the index value to access that particular amount that reside in that index. Index starts from 0 not 1, because computers start their count from the number zero 0.
            Console.WriteLine(phrase.IndexOf("Jain")); // IndexOf return the index in an integer, it indicates where that value reside in the string. If that charachter doesn't reside in the string it returns -1 which means no charachter found in the string.
            Console.WriteLine(phrase.Substring(8)); // Substring takes integer value as a argument and returns the value which begins from that index value and return the rest of the value from and after the index.
            Console.WriteLine(phrase.Substring(8,2)); // In this we passed 2 positional arguments, first where to begin and second how much charachters we want after tha indexed value.
            



        }
    }
}
