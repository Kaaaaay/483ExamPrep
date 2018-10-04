using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46___OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Optional parameters
             * Parameters that are optional
             * You have to define them to be optional
             */

             
            /* Named Arguments
             * 
             */
            Add(5); //This becomes valid if y has a default value
            Add(5, z:10); // The : (colon) allows us to skip the second parameter and use the default one


            Console.ReadLine();

        }

        //Parameters are not optional in this instance, unless you give y a default value
        public static void Add(int x, int y = 4, int z = 3)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }


    }
}
