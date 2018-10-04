using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objective1._2._4
{
    class Program
    {
        //Using a CancellationToken
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task myTask = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                cancellationToken.ThrowIfCancellationRequested();

            }, cancellationToken);


            try
            {
                Console.WriteLine("Please press enter to stop the task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                myTask.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }


            Console.WriteLine("Press enter to close the program");
            Console.ReadLine();
        }
    }
}
