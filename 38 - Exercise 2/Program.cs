using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38___Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter the amount of students: \t");
            int amountStudents = int.Parse(Console.ReadLine());

            int avgGrade = 0;
            int highestGrade = 0;

            
            int[] finalScore = new int[amountStudents];
            string[] studentNames = new string[amountStudents];




            for (int i = 0; i < studentNames.Length; i++)
            {

                Console.Write("Please enter the student #{0} name \t",i+1);
                string name = Console.ReadLine();
                studentNames[i] = name;

                Console.Write("Please enter student #{0} final score: \t",i+1);
                int score = int.Parse(Console.ReadLine());
                finalScore[i] = score;

                avgGrade += score;


                //highest grade

                if (score > highestGrade)
                {
                    highestGrade = score;
                }

            }

            //printing 

            avgGrade /= amountStudents;
            Console.WriteLine("Average = {0}",avgGrade);
            Console.WriteLine("Highest Grade = {0}",highestGrade);


            Console.ReadLine();

        }
    }
}
