using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Writing_a_specification
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Specification
            /*Purpose: Compute the maximum element of an array of decimals
             * Method should be pascal cased
             * Has receiver?(type): No, static method
             * Input: Array of decimals
             * Output: A decimal value
             * Side Effects: None
             * Error case: Array must not be null
             * Error case: Array must not be empty
             */

            decimal[] values = { 2.1m, 3.0m, 5.4m, 0.003m };
            decimal maximum = values.Max();
        }
    }
}
