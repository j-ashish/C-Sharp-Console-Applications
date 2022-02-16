using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two2d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [,] this is the syntax to declare that the array is 2 dimesional.

            int[,] numberGrid = {
            {1,2,3,4},
            {5,6,7,8}
            };

            // To get to the particular value the index method is little different, [array_index,selected_element_index]
            Console.WriteLine(numberGrid[0,0]);

            // When we want to populate the 2d array later we have to define it like this:-
            //datatype[,] variable_name = new datatype[number_of_arrays(rows) , elements_inside_the_arrays(columns)]



        }
    }
}
