using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._3_Short_circuting_the_OR_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool result = x || GetY();

            Console.ReadLine();
        }

        private static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");

            return true;
        }

        
    }
}
