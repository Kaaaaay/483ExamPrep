using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___Searching_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = { "Ole", "Pale", "Reba", "Khanyi", "Boipelo", "Thato", "Katlego" };
            int[] greatgrand = { 1, 0, 0, 0, 1, 0, 1 };

            Console.WriteLine("Search: Enter a child's name");
            string childName = Console.ReadLine();

            bool contains = false;
            int dependants = 0;

            for (int i = 0; i < children.Length; i++)
            {
                if (childName == children[i])
                {
                    contains = true;
                    dependants = greatgrand[i];
                    break;
                }
            }

            if (contains == true)
            {
                Console.WriteLine("This is Mma Mtimkulu's Grandchild");
                Console.WriteLine("The number of children this child has is {0}",dependants);
            }
            else
            {
                Console.WriteLine("{0} Mtimkulu, Can't be", childName);
            }


            Console.ReadLine();
        }
    }
}
