using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___CreateCounterQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        /*
         * Question: You are developing a method named CreateCounters that will create performance counters for an app
         * The method includes the following code
         * 
         * You need to ensure that Counter2 is avaiable for use in Windows Performance Monitor (PerfMon)
         */

        /*
         * Answer
         */

        void CreateCounters()
        {
            if (!PerformanceCounterCategory.Exists("Contoso"))
            {
                var counters = new CounterCreationDataCollection();
                var ccdCounter1 = new CounterCreationData
                {
                    CounterName = "Counter1",
                    CounterType = PerformanceCounterType.AverageTimer32
                };
                counters.Add(ccdCounter1);
                var ccdCounter2 = new CounterCreationData
                {
                    CounterName = "Counter2",
                    CounterType = PerformanceCounterType.AverageBase
                };
                counters.Add(ccdCounter2);
                PerformanceCounterCategory.Create("Contoso", "Help string",
                    PerformanceCounterCategoryType.MultiInstance, counters);

            }
        }
    }
}
