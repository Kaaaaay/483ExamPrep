using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30___Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int guessedNumber;
            int noOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the number between 1 and 10 ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("That was a tad too high :(. ", randomNumber);
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Your guess was a bit too low :(", randomNumber);
                }
                else
                {
                    Console.WriteLine("{0}, is the correct number. You killed it!", randomNumber);
                }
                noOfGuesses++;

            } while (guessedNumber != randomNumber);
            Console.WriteLine("No. of guesses: {0}",noOfGuesses);

            Console.ReadLine();
        }
    }
}
