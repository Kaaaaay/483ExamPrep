using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1_Using_the_equality_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            /*
             * == EQUAL TO 
             * != NOT EQUAL TO
             * <= LESS THAN OR EQUAL TO
             * >= GREATER THAN OR EQUAL TO
             * < LESS THAN
             * > GREATER THAN
             */


            Console.WriteLine( x == y);
            Console.WriteLine(x == z);

            Console.ReadLine();
        }
    }
}
