using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1._2._2
{
    class Program
    {
        //Creating a deadlock
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            Task myTask = Task.Run(() => 
            {
                lock (lockA)
                {
                    Thread.Sleep(5000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            myTask.Wait();

            Console.ReadLine();
        }
    }
}
