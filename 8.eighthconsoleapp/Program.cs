using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mad_libs_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string color , pluralNoun , celebrity;

            Console.Write("Enter a Color: ");
            color = Console.ReadLine();

            Console.Write("Enter a Plural Noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a Celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are "+color);
            Console.WriteLine(pluralNoun+" are blue");
            Console.WriteLine("I Love "+celebrity);
        }
    }
}
