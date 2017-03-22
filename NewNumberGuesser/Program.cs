using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNumberGuesser
{
    class Program
    {
        //method #1
        static int GetUserGuess(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var guess = 0;
            int.TryParse(input, out guess);
            return guess;
        }    

            static void Main(string[] args)
            {

            var target = new Random().Next(1, 101);
            Console.WriteLine($"The target is {target}.");

            var counter = 0;
            var guess = 0;
            var pastGuess = new int[5];
            while (counter < 5 && guess != target)
            {
                //method #1
                var input = GetUserGuess("Pick a number: ");

                var wasAlreadyGuess = false;
                foreach (var userGuess in pastGuess)
                {
                    if (guess == userGuess)
                    {
                        wasAlreadyGuess = true;
                    }
                }

                if (wasAlreadyGuess)
                {
                    Console.WriteLine("You already guessed that. Try again.");
                }
                else
                {
                    pastGuess[counter] = guess;

                    Console.WriteLine($"Your guess was {guess}.");

                    if (guess < target)
                    {
                        Console.WriteLine("Too low, try again.");
                    }
                    else if (guess > target)
                    {
                        Console.WriteLine("Too high, try again");
                    }

                    Console.WriteLine("Your past guesses are:");
                }
                foreach (var userGuess in pastGuess)
                {
                    if (userGuess != 0)
                    {
                        Console.Write($"{userGuess},");
                    }
                }
                counter++;
            }

            if (counter > 4)
            {
                Console.WriteLine("You lost.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You Won!");
                Console.ReadLine();
            }

        }
    }
}
