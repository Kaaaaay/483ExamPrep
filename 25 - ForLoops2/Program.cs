using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___ForLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times you want Hello to be printed");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= amount; i+=1)
            {
                Console.WriteLine("{0}) You did it",i);
            }
            Console.ReadLine();
        }
    }
}
