using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1nUsing_a_delegate
{
    class UseDelegate
    {
        /*
         * A variable that holds a reference to a function/method
         * Once you set it up you can use it as the function
         * Contains the same signature as the function
         * 
         */

        public delegate int Calculate(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public UseDelegate()
        {
            Calculate calc = Add;


            calc = Multiply;

            Console.WriteLine(calc(3, 6));

        }

    }
}
