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
            decimal principal       = ReadPositveDecimal("Please enter the principal amount:      ");
            decimal interestRate    = ReadPositveDecimal("Please enter the interest rate:         ");
            decimal monthlyPayment  = ReadPositveDecimal("Please enter the monthly payment:       ");
            decimal totalInterest   = TotalInterest(principal, interestRate, monthlyPayment);
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
                {
                    //Prompt user again
                    Console.WriteLine("Please enter a decimal value");
                }
                else if (result < 0.0m)
                {
                    Console.WriteLine("Please enter a positive value");
                }
                else
                {
                    return result;
                }
            }
            
        }

        static decimal TotalInterest(decimal principal, decimal interestRate, decimal monthlyPayment)
        {
            if (principal <0.0m)
            {
                throw new ArgumentException("principal must be positive", "principal");
            }
            if (interestRate <0.0m)
            {
                throw new ArgumentException("interest rate must be positive", "interest rate");

            }
            if (monthlyPayment <0.0m)
            {
                throw new ArgumentException("monthly payment must be positive", "monthly payment");
            }

            /*
             * Every month there will be a payment, which reduces
             * The principal and pays interest. This repeats until
             * the principal is gone
             */

            decimal totalInterest = 0.0m;
            decimal currentPrincipal = principal;
            while (0.0m < currentPrincipal)
            {
                decimal currentInterest = (currentPrincipal * interestRate) / 100;
                decimal reduction       = monthlyPayment - currentInterest;
                currentPrincipal        = currentPrincipal - monthlyPayment;
                totalInterest           = totalInterest + currentInterest;

            }
            return totalInterest;
        }
    }
}
