using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Do_While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ola");
            string response = Console.ReadLine();

            while (response == "Ekse")
            {
                Console.WriteLine("Aloha");
                response = Console.ReadLine();
            }
            */

            // Do While Loop

            string response;
            do
            {
                Console.WriteLine("Hello");
                response = Console.ReadLine();

            } while (response == "Huh?");


            Console.ReadLine();
        }
    }
}
