using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(5000);
            });

            int index = Task.WaitAny(new Task[] { longRunning }, 1000);
            if (index ==-1)
            {
                Console.WriteLine("Task timed out");
            }

            Console.ReadLine();
        }
    }
}
