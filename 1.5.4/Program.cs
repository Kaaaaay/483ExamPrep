using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = OpenAndParse(null);

            }
            catch (ArgumentNullException e)
            {

                Console.WriteLine("Argument Null Exception: " + e.Message);
            }

            

            Console.ReadLine();
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("filename", "Filename is required");
            }
            return File.ReadAllText(fileName);
        }
    }
}
