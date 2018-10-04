using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47___Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
            Console.ReadLine();
        }

        public static void MultiplicationTable(int number)
        {
            for (int i = 2; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0,3} * {1,3} = {2,3}",i,number,answer);
            }
        }
    }
}
