using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___Nested_Loops
{
    class Program
    {
        /* Nested Loops
         * Loops within other loops
         */

        static void Main(string[] args)
        {

            #region 10 For Loops to Build a Square
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            */
            #endregion

            Console.Write("Type in the length! \t");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Type in the width \t");
            int width = int.Parse(Console.ReadLine());


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0,-2}","*"); //Space is always allocated to the left first to we need to put a negative sign
                }
            Console.WriteLine();
            }
            if (length == width)
            {
                Console.WriteLine("The shape is a SQUARE!!!!");
            }
            else
            {
                Console.WriteLine("That's definitely a RECTANGLE!!!");
            }
            Console.ReadLine();
        }
    }
}
