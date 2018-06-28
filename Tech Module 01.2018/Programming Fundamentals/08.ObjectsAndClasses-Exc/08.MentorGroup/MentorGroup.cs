using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            string studentDates = Console.ReadLine();
            Dictionary<string, Student> groupOfStudents = new Dictionary<string, Student>();

            while (studentDates != "end of dates")
            {
                string[] dateArgs = studentDates
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (groupOfStudents.ContainsKey(dateArgs[0]))
                {
                   groupOfStudents[dateArgs[0]].Dates.AddRange(ReadVisits(dateArgs, groupOfStudents[dateArgs[0]]));
                }
                else
                {
                    Student student = new Student();
                    student.Name = dateArgs[0];
                    student.Dates = ReadVisits(dateArgs, student);
                    groupOfStudents.Add(dateArgs[0], student);
                }
                studentDates = Console.ReadLine();
            }

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                string[] commentArgs = comment.Split('-').ToArray();
                string name = commentArgs[0];
                string commentary = commentArgs[1];
                List<string> commentaries = new List<string>();

                if (groupOfStudents.ContainsKey(name))
                {
                    if (groupOfStudents[name].Comments == null)
                    {
                        commentaries.Add(commentary);
                        groupOfStudents[name].Comments = commentaries;
                    }
                    else
                    {
                        commentaries.AddRange(groupOfStudents[name].Comments);
                        commentaries.Add(commentary);
                        groupOfStudents[name].Comments = commentaries;
                    }
                }

                comment = Console.ReadLine();
            }

            foreach (var name in groupOfStudents.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);
                Console.WriteLine("Comments:");

                if (name.Value.Comments != null)
                {
                    foreach (var madeComment in name.Value.Comments)
                    {
                        Console.WriteLine($"- {madeComment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                if (name.Value.Dates != null)
                {
                    foreach (var date in name.Value.Dates.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }

        static List<DateTime> ReadVisits(string[] dateArgs, Student student)
        {
            List<DateTime> dates = new List<DateTime>();
            if (dateArgs.Length > 1)
            {
                for (int i = 1; i < dateArgs.Length; i++)
                {
                    DateTime currentDate = DateTime.ParseExact(dateArgs[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dates.Add(currentDate);
                }
            }
            return dates;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
}
