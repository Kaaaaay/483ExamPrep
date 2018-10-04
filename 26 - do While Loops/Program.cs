using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do While Loop - Always guarantees one execution of its body
            //While Loop - may not run if condition is false

            // While Loop Example

            int x = 1;
            /*
            while (x > 11)
            {
                Console.WriteLine("Print");
                x++;
            }
            */
            //The reason why this loop never ran was because the statement was false


            //Do While Example
            do
            {
                Console.WriteLine("One Execution");
                x++;
            } while (x > 3);


            Console.ReadLine();
        }
    }
}
