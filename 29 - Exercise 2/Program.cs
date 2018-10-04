using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding One to Fifty");

            int total = 0;

            for (int adding = 0; adding < 51; adding++)
            {
                total += adding;
            }
            Console.WriteLine("Total = {0}", total);

            Console.ReadLine();
        }
    }
}
