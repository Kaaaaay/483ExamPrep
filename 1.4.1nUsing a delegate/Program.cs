using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1nUsing_a_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            UseDelegate d = new UseDelegate();
            Multicast m = new Multicast();
            m.MultiCast();
            */
            Car c = new Car();
            c.OnChange += C_OnChange;

            c.Speed = 5;
            c.Speed = 100;

            Console.ReadKey();
        }

        private static void C_OnChange()
        {
            Console.WriteLine("Event Fired");
        }
    }
}
