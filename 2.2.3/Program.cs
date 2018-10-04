using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Implicit  conversions - happen all the time, when one type gets converted to another type
            int i = 45;
            double d = i;

            Dog dog = new Dog();
            Animal a = dog;
            
            */

            /*
            //Explicit Conversion

            double a = 45.9;
            int b = (int)a;
            Console.WriteLine(b);
            */
            
            /*
            Dog dog = new Dog();
            Animal animal = dog;

            Dog dog1 = (Dog)animal;
            */


        }
      
    }
    class Animal
    {
        public string Name { get; set; }
    }

    class Dog : Animal
    {
        public void Bark()
        {

        }
    }
}
