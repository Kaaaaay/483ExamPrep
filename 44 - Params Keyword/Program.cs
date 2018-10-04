using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44___Params_Keyword
{
    /*Params keyword - parameter arrays
     *Passing a parameter to an array
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Array declaration
            int[]myArray = { 5, 6, 7, 8, 9, 10 };

            //function calls
            PrintArray(myArray);
            //add params keyword to the int[] array argument in the PrintArray method to get rid of compile error
            PrintArray(3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45); // takes any amount of args
            


            //The Writeline method can extend to as many arguments as possible
            Console.WriteLine("Hello {0} {1} {2}",3,6,9);
            Console.WriteLine("Hello {0} {1} {2} {3} {4} {5}", 3,6,9,12,15,18);
            Console.WriteLine("Hello {0} {1} {2} {3} {4} {5} {6} {7} {8}", 3, 6, 9, 12, 15, 18, 21,24,27);
            /*This is done using the params keyword
             * It allows you to enter any amount of arguments
             * When the arguments get to the function they get put together into an array
             */

            Console.ReadLine();
        }
        //function that prints array to console
        //takes any int array

        
        public static void PrintArray(params int[] array)
        {
            //whatever array length is, it will print all elements in it
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
