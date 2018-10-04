using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5._2_Different_Exception_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "55555555555555555555555";

            try
            {
                //This will throw an exception

                int i = int.Parse(s);

            }
            catch (ArgumentNullException ee)
            {
                Console.WriteLine("Null Exception: {0}", ee.Message);
            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid Value: {0}", e.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Overflow Exception: {0}",oe.Message);

            }
            catch (Exception eg)
            {
                Console.WriteLine("Exception: " ,eg);
            }


            Console.WriteLine("Program keeps going");
            Console.ReadLine();
        }
    }
}
