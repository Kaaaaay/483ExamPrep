using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Creating_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * int myArray;
             * myArray = 5;
             * int myArray;
             * myArray = 3;
             * int myArray;
             * myArray = 8;
            */

            //This is equivalent to that which is above
            //This format is best for getting user input
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 3;
            myArray[2] = 8;

            Console.WriteLine("First number in index: ",myArray[0]);

            int[] myArray2 = new int[3] { 5,10,15};

            Console.WriteLine(myArray2[1]);

            int[] myArray3 = new int[] { 5,10,15};
            Console.WriteLine(myArray3[2]);

            int[] myArray4 = { 5,10,15};
            Console.WriteLine(myArray4[2]);


        }
    }
}
