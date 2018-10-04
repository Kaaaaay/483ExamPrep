using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1nUsing_a_delegate
{
    class Multicast
    {
        /*
         * A delegate that holds multiple references to multiple classes
         */

        public delegate void Del();

        public void MethodOne()
        {
            Console.WriteLine("Method One");
        }

        public void MethoodTwo()
        {
            Console.WriteLine("Method Two");
        }

        public void MultiCast()
        {
            Del d = MethodOne;
            d += MethoodTwo;


            d();
        }
    }
}
