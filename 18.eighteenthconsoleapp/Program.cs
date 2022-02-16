using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "monkey";
            string guess = "";
            int guessLimit = 3;
            int guessCount = 0;

            while (guess != secretWord) // This while loop will run until the user enter the value as the secret key.
            {
                guessCount++;
                Console.Write("Enter Guess: ");
                guess = Console.ReadLine();
                if (guessCount == guessLimit)
                {
                    Console.WriteLine("You Are Out Of Your Moves");
                    break;
                }
                else if (guess == secretWord)
                {
                    Console.WriteLine($"You Won In {guessCount} Moves.");
                }
            }
            if (guess != secretWord)
            {
                Console.WriteLine("You Lose..!!!");
            }

        }
    }
}
