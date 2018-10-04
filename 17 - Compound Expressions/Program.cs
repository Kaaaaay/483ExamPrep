using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Compound_Expressions
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

            Console.WriteLine("Parking Space App");
            const int pOne = 50;
            const int pTwo = 50;
            Console.WriteLine("\nPlease enter the number of parking spaces allocated per floor."
                + "\n(Number cannot be greater than 50)");

            Console.Write("\n1) Gym \t\t");
            int pOneParked = int.Parse(Console.ReadLine());
            Console.Write("2) Shops \t");
            int pTwoParked = int.Parse(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("Parking Space App");
            Console.WriteLine("Please choose between the following: \n1) Gym \n2) Shops");
            int pBay = int.Parse(Console.ReadLine());
            int remainingSpace;

            if (pBay == 1)
            {
                remainingSpace = pOne - pOneParked;
                int altOption = pTwo - pTwoParked;
                Console.WriteLine();
                if (remainingSpace == 0)
                {
                    Console.WriteLine("Selected Parking Bay Full. \n1) Gym: \t\t{0} \n2) Shops:\t\t{1}", remainingSpace, altOption);
                }
                else
                {
                    Console.WriteLine("There are {0} parking spaces available on P1, please advise the client to proceed", remainingSpace);
                    remainingSpace--;
                    Console.WriteLine("Current Parking Space Available {0}", remainingSpace);
                }
            }
            else
            {

                remainingSpace = pTwo - pTwoParked;
                int altOption = pOne - pOneParked;
                Console.WriteLine();
                if (remainingSpace == 0)
                {
                    Console.WriteLine("Selected Parking Bay Full. \n1) Gym: \t\t {0} \n2) Shops:\t\t {1}", remainingSpace, altOption);

                }
                else
                {
                    Console.WriteLine("There are {0} parking spaces available on P2, please advise the client to proceed", remainingSpace);
                    remainingSpace--;
                    Console.WriteLine("Current Parking Space Available {0}", remainingSpace);
                }
            }





            Console.ReadLine();
        }
    }
}
