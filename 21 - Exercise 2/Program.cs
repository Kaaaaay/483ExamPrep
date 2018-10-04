using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gijiza Lawnmowers");
            Console.WriteLine("Weekly Fee");
            Console.WriteLine("Under 400 Feet   = $25");
            Console.WriteLine("400 - 600 Feet   = $35");
            Console.WriteLine("600 - Over       = $50");

            const double fee1 = 25;
            const double fee2 = 35;
            const double fee3 = 50;
            const double seasonFee = 20;

            Console.WriteLine();

            Console.Write("Please enter the length of your lawn: \t");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Please enter the width of your lawn: \t");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double season1 = fee1 * seasonFee;
            double season2 = fee2 * seasonFee;
            double season3 = fee3 * seasonFee;

            Console.WriteLine();


            if (area < 400 )
            {
                Console.WriteLine("Weekly mowing fee: \t{0}",fee1);
                
                Console.WriteLine("Mowing fee for season: \t{0}",season1);
            }
            else if (area < 600)
            {
                Console.WriteLine("Weekly mowing fee: \t{0}", fee2);
                Console.WriteLine("Mowing fee for season: \t{0}", season2);
            }
            else
            {
                Console.WriteLine("Weekly mowing fee: \t{0}",fee3);
                Console.WriteLine("Mowing fee for season: \t{0}", season3);
            }


            Console.ReadLine();
        }
    }
}
