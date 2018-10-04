using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Mortgage_App
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal;
            while (true)
            {
                Console.WriteLine("Please enter the current principal:  ");
                string principalText = Console.ReadLine();
                bool success = decimal.TryParse(principalText, out principal);
                if (!success)
                    Console.WriteLine("Please enter a decimal value");
                else
                    break;
            }

        }
    }
}
