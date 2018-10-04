using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._1_Parsing_an_invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = "Hello";

            try
            {
                //This will throw an exception

                int i = int.Parse(s);

            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid Value: {0}", e.Message);
            }

            Console.WriteLine("Program keeps going");
            Console.ReadLine();
        }
    }
}
