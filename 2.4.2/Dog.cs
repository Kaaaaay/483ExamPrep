using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._2
{
    class Dog : IAnimal
    {
        public void Bark ()
        {
            Console.WriteLine("Woof Woof!");
        }

        public void Move()
        {
            Console.WriteLine("Dog Move"); ;
        }
    }
    class Cat: IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Cat Move"); ;
        }
    }
}
