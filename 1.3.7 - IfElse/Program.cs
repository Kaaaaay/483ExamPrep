using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._7___IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            bool c = true;
            bool z = false;

            if (b == true)
            {
                Console.WriteLine("True");
            }
            else if (c ==  true)
            {
                if (z == false)
                {
                    Console.WriteLine("c is False");

                }
            }
            else
            {
                Console.WriteLine("c and b are false");
            }
        }
    }
}
