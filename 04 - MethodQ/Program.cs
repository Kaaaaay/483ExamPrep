
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___MethodQ
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
            dynamic message = new ExpandoObject();
            message.From = "Cape";
            message.To = "Cairo";
            message.Content = "Azania";
            SendMessage(message);
            Console.ReadLine();
        }

        private static void SendMessage(dynamic msg)
        {
            Console.WriteLine(msg.From);
            Console.WriteLine(msg.To);
            Console.WriteLine(msg.Content);

        }
    }
}
