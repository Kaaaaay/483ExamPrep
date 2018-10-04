using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._2_Boolean_OR_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool x = true;
            //bool y = false;


            // || - only one has to be true to make the whole thing true
            //          true||false
            //bool result = x || y;
            //Console.WriteLine(result);

            int x = 5;
            int y = 5;
            int z = 6;

            // As long as one of them is true then tthe whole statement is true
            bool result = x != y || y == z;

            Console.ReadLine();
        }
    }
}
