using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._1_Implement_a_Class_Hierachy
{
    interface IExample : ITest
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get;set; }

    }

    interface ITest
    {
        void DoTest();

    }
}
