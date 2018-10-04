using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Debugging_a_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = { 3.0m, 45.0m, 9.0m, 300.0m };
            decimal maximum = Maximum(null);
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

            // TODO: Implement this method
            return 555.0m;
        }
    }
}
