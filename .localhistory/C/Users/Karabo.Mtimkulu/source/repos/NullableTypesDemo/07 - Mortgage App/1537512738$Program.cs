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
            ReadPositveDecimal();

        }

        static decimal ReadPositveDecimal( string prompt)
        {
            decimal result;
            while (true)
            {
                //Prompt user for input
                Console.Write(prompt);
                //Read user input
                string principalText = Console.ReadLine();

                //Convert Principal to variable
                bool success = decimal.TryParse(principalText, out result);

                //loop - executes if conversion fails
                if (!success)
                    //Prompt user again
                    Console.WriteLine("Please enter a decimal value");
                else if (result < 0.0m)
                    Console.WriteLine("Please enter a positive value");
                else
                    return result;
            }
            
        }
    }
}
