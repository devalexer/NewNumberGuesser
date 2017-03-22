using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            var target = new Random().Next(1, 101);
            Console.WriteLine($"the target is {target}");

            var counter = 0;
            var guess = 0;
            var pastGuess = new int[5];
            while (counter < 5 && guess != target)
            {
                Console.WriteLine("Give me your best guess");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

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
                    Console.WriteLine("You aalready guesses that, foool");
                }
                else
                {
                    pastGuess[counter] = guess;

                    Console.WriteLine($"your guess was {guess}");

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
                Console.WriteLine("You lost :-(");
            }
            else
            {
                Console.WriteLine("You Won!");
            }

        }
    }
}
