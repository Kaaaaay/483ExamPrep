using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective1._2
{
    class Program
    {
        // Sequential Back to Back Loop

        static void Main(string[] args)
        {
            int n = 0;
            object _lock = new object();

            Task myTask = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock)
                    {
                        n++;
                    }

                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    n--;
                }
            }

            myTask.Wait();
            Console.WriteLine(n);

            Console.ReadLine();
            
        }
    }
}
