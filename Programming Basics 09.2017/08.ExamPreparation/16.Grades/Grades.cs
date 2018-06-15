using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double excellent = 0.0;
            double veryGood = 0.0;
            double good = 0.0;
            double poor = 0.0;
            double averageGrade = 0.0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.0 && grade < 3)
                {
                    poor++;
                }
                else if (grade < 4)
                {
                    good++;
                }
                else if (grade < 5)
                {
                    veryGood++;
                }
                else
                {
                    excellent++;
                }
                averageGrade += grade;
            }

            excellent = excellent / students * 100;
            veryGood = veryGood / students * 100;
            good = good / students * 100;
            poor = poor / students * 100;
            averageGrade = averageGrade / students;

            Console.WriteLine("Top students: {0:f2}%", excellent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", veryGood);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", good);
            Console.WriteLine("Fail: {0:f2}%", poor);
            Console.WriteLine("Average: {0:f2}", averageGrade);
        }
    }
}
