using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Value_Types_and_Reference_Types
{
    class Program
    {

        /*
         * Structs (int, bool, char, etc) are value types
         * Value types are 
         * String (Reference Types)
         * Reference Types are classes
         * 
         */


        static void Main(string[] args)
        {
            //x is variable, 5 is data, they're stuck together
            int x = 5;

            //r is reference, new Random() is data, these are two seperate locations
            Random r = new Random();

        }
    }
}
