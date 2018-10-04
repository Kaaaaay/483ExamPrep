using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._5_Short_circuting_the_AND_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            bool result = (input != null) && GetY();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static bool GetY()
        {
            Console.WriteLine("OUTPUT");
            return true;
        }
    }
}
