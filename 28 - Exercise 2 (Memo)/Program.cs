using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Exercise_2__Memo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 50; i++)
            {
                sum += i;
            }

            Console.WriteLine("The sum is {0}",sum);
            Console.ReadLine();
        }
    }
}
