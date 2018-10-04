using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2_Protected_Access_Mod
{
    class Student
    {
        protected int age;
        public double marks;
        public string name;

        public void Test()
        {
            this.name = "Test";
        }


    }

    class TestClass : Student
    {
        public void Test()
        {
            this.name = "";
        }
    }
}
