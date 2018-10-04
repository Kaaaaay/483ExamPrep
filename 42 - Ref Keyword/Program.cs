using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42___Ref_Keyword
{
    class Program
    {
        //Passing by Reference using Ref Keyword
        static void Main(string[] args)
        {
            //You can only use the ref keyword if there is a value in the variable you
            int studentGrade = 81;
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);
            Console.ReadLine();

              
        }

        //By adding a ref keyword we are forcing a ref type passing
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }


    
    }
}
