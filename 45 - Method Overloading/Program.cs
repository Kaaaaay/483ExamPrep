using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45___Method_Overloading
{
    //Method overloading
    class Program
    {
        static void Main(string[] args)
        {
            //Different methods will run according to the valid args
            Add(3, 6);
            Add("Hello", "World");
            Add(3.3, 6.3);
        }

        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void Add(string x, string y)
        {
            string answer = x + "" + y;
            Console.WriteLine(answer);
        }

        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
