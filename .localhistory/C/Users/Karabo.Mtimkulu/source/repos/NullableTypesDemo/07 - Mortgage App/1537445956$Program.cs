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
                //Prompt user for input
                Console.Write("Please enter the current principal:  ");
                //Read user input
                string principalText = Console.ReadLine();

                //Convert Principal to variable
                bool success = decimal.TryParse(principalText, out principal);

                //loop - executes if conversion fails
                if (!success)
                    //Prompt user again
                    Console.WriteLine("Please enter a decimal value");
                else
                    break;
            }

        }
    }
}
