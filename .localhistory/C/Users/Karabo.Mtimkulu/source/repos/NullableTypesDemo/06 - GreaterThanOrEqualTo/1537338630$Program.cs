using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___GreaterThanOrEqualTo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMaximum();
            Console.ReadLine();
        }

        static void TestMaximum()
        {
            decimal[] onePositive = { 12.3m };
            decimal[] oneNegative = { -450.3m };
            decimal[] oneZero = { 0.0m };
            decimal[] nineAscendingNoDuplicatesPositive = { 3.0m, 6.0m, 9.0m, 12.0m, 15.0m, 18.0m, 21.0m, 24.0m, 27.0m, 30.0m };

            VerifyTest(Maximum(onePositive), 12.3m, "one positive");
            VerifyTest(Maximum(oneNegative), -450.3m, "one negative");
            VerifyTest(Maximum(oneZero), 0.0m, "one zero");
            VerifyTest(Maximum(nineAscendingNoDuplicatesPositive), 30.0m, "Nine Ascending no duplicates positive");



        }

        static void VerifyTest(decimal observed, decimal expected, string name)
        {
            if (expected == observed)
            {
                Console.WriteLine($"{name} Passed");
            }
            else
            {
                Console.WriteLine($"{name} Failed - observed {observed} ");
            }
        }


        static decimal Maximum(decimal[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "Array cannot be null");
            }

            if (values.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty", "values");
            }


            decimal biggestSoFar = values[0];
            foreach (decimal item in values)
            {

                if (item > biggestSoFar)
                {
                    biggestSoFar = item;
                }
            }
            //Add postconditions
            Debug.Assert(Contains(values, biggestSoFar), "Postcondition is violated ");
            Debug.Assert(isGreaterThanOrEqualToAll(values, biggestSoFar));



            return biggestSoFar;
        }

        static bool Contains(decimal[] values, decimal value)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "Array must not be null");
            }
            bool result = false;
            foreach (var item in values)
            {
                if (item == value)
                {

                    result = true;
                    break;

                }
            }
            return result;

        }

        static bool isGreaterThanOrEqualToAll(decimal[] values, decimal value)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "Array muts not be null");
            }
            foreach (var item in values)
            {
                if (value<item)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
