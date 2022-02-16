using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //datatype[] arrayname = { 'elements', 'seperated', 'by', 'comma' }; This is the way to create an array.
            int[] luckyNumbers = {4,8,15,16,23,42 };

            Console.WriteLine(luckyNumbers[0]); // To access the element we have to provide the index inside the square brackets. Index begins from 0.

            luckyNumbers[1] = 900; // This is the way to update the particular value with the index.

            string[] friends = new string[5]; // This way we can create the string when we are not sure about the data, but we have to pass the value inside the brackets after declaring, this value will be the length of the elements that this array can hold.
            friends[0] = "Jim"; // this way we are populating the array.
            friends[1] = "Kelly";
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);


        }
    }
}
