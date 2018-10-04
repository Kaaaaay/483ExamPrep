using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._6_Is_and_As
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = animal as Dog;
            if (dog != null)
            {
                dog.Bark();
            }
        }
    }
    class Animal
    {
        public string Name { get; set; }
    }
    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("WOOF");
        }
    }
}
