using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23___While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //definite loop     -   Has a predefined ending point
            //indefinite loop   -   Will end but we don't know when
            //infinite loop     -   never ends
            //For loop work better for definite loops, While loops shine with indefinite loops


            #region Indefinite Loop 1
            //indefinite loop
            /*
            int x = 1;
            while (x > 0)
            {   
                Console.WriteLine("Hello");
                Thread.Sleep(2000);
            }
            */

            #endregion

            #region Definite Loop
            /*
//x++ to increment x so that it prints 5 times and no more than that
int x = 0; // controller
while (x < 5) // condition
{
    Console.WriteLine("Hello");
    Thread.Sleep(1000);
    x++; //alter
}

*/
            #endregion


            //indefinite loop example

            int runningTotal = 0;

            Console.WriteLine("Enter a number or -1 to quit");
            int number = int.Parse(Console.ReadLine());
            while (number !=-1)
            {
                runningTotal += number;
                Console.WriteLine("Enter a number or -1 to quit");
                number = int.Parse(Console.ReadLine());
            }
            //This is the break point for the loop
            Console.WriteLine("The total is  {0}",runningTotal);


            Console.ReadLine();
        }
    }
}
