using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47___Exercise_1
{
    class Program
    {
        /*Exercise 1
         * Create a console-based application whose Main() method
         * asks the user to input an integer and
         * calls a method named MultiplicationTable
         * which displays the results of multiplying the integer
         * by each of the numbers 2 through 10
         */
        
        static void Main(string[] args)
        {
            Console.Write("Welcome... \nPlease enter the number to be multiplied by numbers 2 through 10");
            Console.Write("\nYour number: ");

            int userInput = int.Parse(Console.ReadLine());
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for (int i = 0; i < numbers.Length; i++)
            {

                MultiplicationTable(userInput, numbers[i]);
            }

            Console.ReadLine();


        }
        public static void MultiplicationTable(int x, int y)
        {
            int answer = x * y;
            Console.WriteLine("{0}  x   {1}     = {2}", x, y, answer);

        }
    }
}
