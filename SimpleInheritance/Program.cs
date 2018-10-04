using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    class Program
    {

        /*Single Inheritance
         * B inherits a and F(), it adds b and G()
            - constructors are not inherited
            - inherited methods can be overridden (see later)
         * 
         * 
         */
        static void Main(string[] args)
        {
        }



        class A
        { // base class
            int a;
            public A()
            {
            }
            public void F()
            {
            }
        }
        class B : A
        { // subclass (inherits from A, extends A)
            int b;
            public B()
            {
            }
            public void G()
            {
            }
        }
    }
}
