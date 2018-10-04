using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36__Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangular Array - Each row has the same amount of columns 
             * Example
             * 5 6 7
             * 6 7 8
             * 9 1 0
             * Jagged Array     - An Array of arrays
             * 5 8 9
             * 1 2 3 4 5
             * 7 8 4
             */

            #region Rectangular Array
            /*
             * 
             * 
            //This is how you declare a multi-dimensional array int [rows,columns]
            int[,] myArray = new int[3, 4];

            // * * * *
            // * * * *
            // * * * * 
            //This is how the array would look

            myArray[0, 0] = 3;
            myArray[0, 1] = 6;
            myArray[0, 2] = 9;
            myArray[0, 3] = 1;

            myArray[1, 0] = 2;
            myArray[1, 1] = 4;
            myArray[1, 2] = 9;
            myArray[1, 3] = 6;

            myArray[2, 0] = 9;
            myArray[2, 1] = 1;
            myArray[2, 2] = 2;
            myArray[2, 3] = 3;

            //Short-hand version

            int[,] myArray2 = { { 3, 6, 9, 12 },
                                { 24, 48, 96, 192 },
                                { 9, 18, 27, 36 } };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine();

            }           
             */
            #endregion


            //Jagged Array - An array of arrays

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[6];
            jaggedArray[2] = new int[9];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
