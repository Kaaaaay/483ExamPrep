using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___Useful_Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Binary Search - Works Only on Sorted Data
             *Built in to default array data type
             * Binary search more efficient, it cuts down a certain space of the data
             */

            #region Binary Search
            /*
           int[] myArray = { 6, 12, 18, 24, 30, 36, 42 };
           Console.WriteLine("Please enter a number to check if it exists");
           int number = int.Parse(Console.ReadLine());

           int answer = Array.BinarySearch(myArray, number);

           if (answer < 0)
           {
               Console.WriteLine("The number does not exist");
           }
           else
           {
               Console.WriteLine("The number's position in the array is {0}",answer);
           }
           */
            #endregion

            #region Sorting an Array
            /*
            int[] myArray = { 0, 4, 99, 2, 100, 55, 79, 23, 42 };
            Array.Sort(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            */
            #endregion

            #region Reverse and Array
            int[] myArray = { 0, 4, 99, 2, 100, 55, 79, 23, 42 };
            Array.Reverse(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            #endregion



            Console.ReadLine();
        }
    }
}
