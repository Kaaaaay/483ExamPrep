using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___MethodQ
{
    class Program
    {

        /*
         *70-483 Q
         * You are developing an apoplication that includes a method named SendMessage.
         * You need to ensure that the SendMessage() method is called with the required parameters
         * 
         */


        static void Main(string[] args)
        {
            var message = new { From = "Cape", To = "Cairo", Content = "Azania" };
            SendMessage(message);
            Console.ReadKey();
        }

        private static void SendMessage(dynamic msg)
        {
            Console.WriteLine(msg.From);
            Console.WriteLine(msg.To);
            Console.WriteLine(msg.Content);

        }
    }
}
