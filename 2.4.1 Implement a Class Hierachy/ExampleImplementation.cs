using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._1_Implement_a_Class_Hierachy
{
    class ExampleImplementation : IExample
    {
        public int this[string index]
        {
            get { return 42; }
            set { }
        }

        public int Value
        { get; set; }

        public event EventHandler ResultRetrieved;

        
        public void DoTest()
        {
            throw new NotImplementedException();
        }

        public string GetResult()
        {
            return "result";
        }
    }
}
