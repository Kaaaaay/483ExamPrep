using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43___OutKeyword
{
    class Program
    {

        //Passing by Reference using Ref Keyword
        static void Main(string[] args)
        {
            //You can only use the ref keyword if there is a value in the variable you
            int studentGrade;
            int add;
            int multi;

            GiveExtraCredit(out studentGrade);
            Console.WriteLine(studentGrade);

            AddandMult(3, 3,out add,out multi);
            Console.WriteLine(add);
            Console.WriteLine(multi);

            Console.ReadLine();


        }

        //By adding a ref keyword we are forcing a ref type passing
        public static void GiveExtraCredit(out int studentGrade)
        {
            //Because student grade has no value, you have to assign it a value inside the function first 
            studentGrade = 0;
            studentGrade += 3;
        }

        public static void AddandMult(int a, int b, out int added, out int mult)
        {
            added = a + b;
            mult = a * b;
        }
    }
}
