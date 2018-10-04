using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___CompoundExpressionsinIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // The &&(AND) Operator
            //True  && True     = True
            //True  && False    = False
            //False && True     = False
            //False && False    = False
            //AND is only TRUE when both conditions are TRUE


            //The || (OR) operator
            //True  || True     = True
            //True  || False    = True
            //False || True     = True
            //False || False    = False
            //OR is only FALSE when both conditions are FALSE

            Console.WriteLine("Age App v2.0 for Funding");

            Console.WriteLine("\nAmount: \n1) R1 000.00 - R250 000.00 \n2) R250 000.01 - R500 000.00 \n3) R500 000.01 +\n");
            Console.Write("Select Amount Range: ");
            int amountIndex = int.Parse(Console.ReadLine());

            Console.Write("\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Are you disabled? Type True or False \n1) True \n2) False  \n");
            bool disability = bool.Parse(Console.ReadLine());

            

            if (age >= 18 && age <=36 && disability)
            {
                Console.WriteLine("\nYou qualify for the funding plus the Disability Bonus. Please upload a Business Plan and proof of Disability.");
            }
            else if (age >= 18 && age <= 36 && !disability)
            {
                Console.WriteLine("\nYou qualify for the funding only. Please upload a Business Plan.");

            }
            else if (age <= 18 && age <= 36 && disability)
            {
                Console.WriteLine("\nYou are too young for the programme even though you qualify for the Disability Bonus");
            }
            else if (age >= 18 && age >= 36 && disability)
            {
                Console.WriteLine("\nYou are too old for the programme even though you qualify for the Disability Bonus");
            }
            else if (age >= 18 && age >= 36 && !disability)
            {
                Console.WriteLine("\nYour do not qualify for the programme AT ALL, Sorry.");
            }
            else
            {

            }
            Console.ReadLine();
        }
    }
}
