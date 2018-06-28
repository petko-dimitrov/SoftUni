using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> classOfStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student();
                student.Name = input[0];
                List<double> grades = new List<double>();

                for (int j = 1; j < input.Length; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                student.Grades = grades;
                classOfStudents.Add(student);
            }

            foreach (var student in classOfStudents.Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}
