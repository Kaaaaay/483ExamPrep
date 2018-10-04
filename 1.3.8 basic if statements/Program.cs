using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._8_basic_if_statements
{
    class Program
        //Condition Operator
    {
        static void Main(string[] args)
        {
            int x = 10;

            //if x = 10, then z = 10, else z = 0
            int z = x == 10 ? 10 : 0; ;

            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
