using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Foreach___Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] marks = { 80, 4, 99, 50, 100, 100, 96, 77, 23 };

            //foreach

            foreach (int score in marks)
            {
                //Foreach loop is read-only, used to print and not 
                Console.WriteLine(score);
            }

            Console.ReadLine();
        }
    }
}
