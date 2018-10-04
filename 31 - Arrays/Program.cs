using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Arrays
{
    class Program
    {
        /// <Arrays>
        ///  List of numbers
        ///  Store a large piece of data in one entity
        ///  Group of data os the same data type
        /// </Arrays>

        static void Main(string[] args)
        {
            //How to declare an array

            //You can assign values to individual array elements, by using the index number, like −
            double[] balance = new double[10];
            balance[0] = 4500.0;

            //You can assign values to the array at the time of declaration, as shown −
            double[] balance2 = { 2340.0, 4523.69, 3421.0 };

            //You can also create and initialize an array, as shown −
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };

            //You may also omit the size of the array, as shown −
            int[] marks2 = new int[] { 99, 98, 92, 97, 95 };

            /*You can copy an array variable into another target array variable.
             * In such case, both the target and source point to the same memory location −
            */
            int[] marks3 = new int[] { 99, 98, 92, 97, 95 };
            int[] score = marks;

            /*
             * When you create an array, C# compiler implicitly initializes each array element to a default value 
             * depending on the array type. For example, for an int array all elements are initialized to 0.
             */

            /*Accessing Array Elements
             * An element is accessed by indexing the array name.
             * This is done by placing the index of the element within square brackets after the name of the array. 
             * For example,             
             */
            double salary = balance[9];


        }
    }
}
