using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48___Exercise_2
{
    class Program
    {
        /* Create a console-based application whose main() method
        * prompts the user for an integer value, in turn, passes
        * the value to a method that squares the number and to a
        * method that cubes the number. The Cube() method
        * should call the Square() method. The Main() method
        * displays the results returned from each of the other methods
        */

        static void Main(string[] args)
        {
            Console.Write("Enter an integer value");
            int number = int.Parse(Console.ReadLine());
            Square(number);
            Cube(number);


            Console.ReadLine();
        }

        public static void Square(int number)
        {
            int squared = Convert.ToInt32(Math.Pow(number, 2));
            //Console.WriteLine("Squared: {0}", squared);
        }

        public static void Cube(int number)
        {
            Square(number);
            int cubed = Convert.ToInt32(Math.Pow(number, 3));
            Console.WriteLine("Cubed: {0}",cubed);
        }

    }
}
