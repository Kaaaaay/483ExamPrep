using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomGenerator = new Random();
            int randomNumber = RandomGenerator.Next(1, 11);

            Console.WriteLine("Guessing Game :)");

            Console.WriteLine();

            Console.WriteLine("Guess the random number  between 1 and 10:");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Corrrrrrrrrrect, the random number is {0}",randomNumber);
            }
            else if (userNumber>randomNumber)
            {
                Console.WriteLine("TOO HIGH MFO, The random number generated actually was {0}",randomNumber);
            }
            else
            {
                Console.WriteLine("TOO LOW, The random number generated  was {0} actually", randomNumber);
            }

            Console.ReadLine();
        }
    }
}
