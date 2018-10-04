
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_Creating_Types
{
    class Program
    {
        //Enum - Group of contant variables

        public enum Days
        {
            //You can set value for the first and the rest will auto increment
            Sat = 1,
            Sun,
            Mon,
            Tue,
            Wed,
            Thur,
            Fri
        };

        static void Main(string[] args)
        {
            Days myDay = Days.Fri;
            Console.WriteLine((int)myDay);

        }
    }
}
