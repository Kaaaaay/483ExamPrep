using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28____Exercise_1__Memo_
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;
            do
            {
                Console.Write("Please enter a valid pay rate: \t");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);
            Console.WriteLine("The valid payrate you entered is {0}", payRate);


            Console.ReadLine();
        }
    }
}
