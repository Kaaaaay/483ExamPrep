using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] zipCode =  { 1190, 1152, 2194, 5555, 6666, 7777, 8888, 9999, 3333, 1101 };
            Array.Sort(zipCode);
            
        
            Console.WriteLine("In No Time Delivery Service");
            Console.WriteLine();
            Console.Write("Please enter your zip code\t");

            int userZipCode = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(zipCode,userZipCode);

            if (answer < 0)
            {
                Console.WriteLine("Unfirtunately we do not deliver your area. Zip Code:{0}", userZipCode);

            }
            else
            {
                Console.WriteLine("We deliver to your area. Zip Code {0}", userZipCode);

            }


            Console.ReadLine();
        }
    }
}
