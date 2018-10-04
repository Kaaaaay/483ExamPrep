using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your hourly pay rate: \t");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            if (hourlyPayRate<7.50 || hourlyPayRate >49)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("The rate is okay");

            }

            Console.ReadLine();
        }
    }
}
