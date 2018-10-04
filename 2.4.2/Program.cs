using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Move();

            //IAnimal dog is pointing to some Dog implementation object in the heap
            IAnimal d = new Dog();
            d.Move();
            // We however do not see the Bark object


            Cat cat = new Cat();

            MoveAnimal(d);
            MoveAnimal(cat);

            Console.ReadLine();
        }
        static void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }
    }
}
