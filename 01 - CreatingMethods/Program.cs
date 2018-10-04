using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___CreatingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayMessage();
            int asnwer = Add(25, 6);
            int secondAnswer = Add(500, 350);
            Console.WriteLine(secondAnswer);
            int a = int.Parse(Console.ReadLine());
        }
        /*
        public static void DisplayMessage()
            //Parameters - any info method needs to display text
        {
            Console.WriteLine("Hello World");
        }*/
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

    }
}
