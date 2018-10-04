using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hourly Pay Rate Application");
            Console.Write("\nEnter your hourly pay rate: \t");
            
            
            double rate = double.Parse(Console.ReadLine());

            while (rate < 5.65 || rate > 49.99)
            {

                Console.Write("\nEnter your hourly pay rate: \t");
                rate = double.Parse(Console.ReadLine());

            }


            Console.WriteLine("The valid pay rate is {0}",rate);

            Console.ReadLine();
        }
    }
}
