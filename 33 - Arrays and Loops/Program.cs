using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _33___Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 80, 4, 99, 50, 100, 100, 96, 77,23 };


            /*If we were to use arrays without loops
            marks[0] += 3;
            marks[1] += 3;
            marks[2] += 3;
            marks[3] += 3;
            marks[4] += 3;
            */

            for (int i = 0; i < marks.Length ; i++)
            {
                marks[i] += 3;

                Console.WriteLine(marks[i]);
                Thread.Sleep(1000);

            }

            Console.ReadLine();
        }
    }
}
