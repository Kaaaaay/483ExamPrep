using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3)
            {
                goto customLabel;
            }
            x++;

            customLabel:
            Console.WriteLine(x);
        }
    }
}
