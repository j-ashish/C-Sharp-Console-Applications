using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please Enter The Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please Enter The Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please Enter The Sex of The Charachter He or She: ");
            //string sex = Console.ReadLine();

            //Console.WriteLine($"There once was a man named {name}");
            //Console.WriteLine($"{sex} was {age} years old");
            //Console.WriteLine($"{sex} really liked the name {name}");
            //Console.WriteLine($"But didn't like being {age}");

            string charachterName = "Ashish Jain";
            int charachterAge;
            charachterAge = 22;

            Console.WriteLine("There once was a man named "+ charachterName);
            Console.WriteLine("He was "+charachterAge+" years old");

            charachterName = "Jason";
            Console.WriteLine("He really liked the name "+ charachterName);
            Console.WriteLine("But didn't like being "+charachterAge);

        }
    }
}
