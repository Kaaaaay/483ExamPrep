using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._7_Dynamic_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Keyword - Makes C# a weakly typed language
            /*
             * Dynamic Keyword - go from statcly typed language to a weak one
             * It does checks at run time, no compile errors
             * Office Automation APIs & to work on JSON code
             */

            dynamic t = "Hello";
            dynamic k = 45;
            Console.WriteLine(t.ToString());
        }
    }
}
