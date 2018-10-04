using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._9_switchstatements
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            switch (x)
            {
                case 10:
                    {
                        Console.WriteLine("The value is 14");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("The value is 13");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("The value is 15");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("The value is not 13,14 nor 15");
                        break;
                    }



            }

            Console.ReadLine();
        }
    }
}
