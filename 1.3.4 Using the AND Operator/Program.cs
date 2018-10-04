using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._4_Using_the_AND_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //The AND operator only makes the entire expression true only if everything is true

            int value = -1;
            //              true      +     true        = true
            //              true      +     false       = false
            //              false     +     true        = false
            //              false     +     false       = false
            bool result = (value > 0) && (value >= 100);

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
