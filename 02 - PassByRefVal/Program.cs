using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___PassByRefVal
{
    class Program
    {
        //int - double - bool - etc are VALUE type references
        //Anything that is a struct is a value type
        //Anything with a class is a reference type
        /*
         * Pass by Value passes a copy, pass by reference passes the exact location of the variable in memory
         * Passing by Reference gives you access to the object/variable
        */

        //Pass by Reference vs Pass by Value
        static void Main(string[] args)
        {
            //Pass by value
            int student1Grade = 75;
            Console.WriteLine("Student grade before extra credit {0}",student1Grade);
            GiveExtraCredit(student1Grade);
            Console.WriteLine("Student grade after extra credit {0}",student1Grade);

            //Pass by Reference Type
            //An array is A REFERENCE TYPE
            int[] grades = new int[1]; //new keyword lets us know that this is a reference type
            grades[0] = 75;
            Console.WriteLine("Student grade before extra credit {0}", grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Student grade after extra credit inside function {0}", grades[0]);

            Console.ReadKey();

        }
        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine("Student grade after extra credit inside function {0}", studentsGrade);

        }
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }
    }
}
