using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Town> towns = new List<Town>();
            Town currentTown = new Town();

            while (input != "End")
            {
                if (input.Contains("=>"))
                { 
                    string[] townInfo = input.Split(new char[] {'=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string town = townInfo[0].Trim();
                    string lab = townInfo[1].Trim();
                    int labCapacity = int.Parse(lab[0].ToString());
                    Town newTown = new Town();
                    newTown.Name = town;
                    newTown.LabCapacity = labCapacity;
                    newTown.Students = new List<Student>();
                    currentTown = newTown;
                    towns.Add(newTown);
                }
                else
                {
                    string[] studentInfo = input.Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
                    string name = studentInfo[0].Trim();
                    string email = studentInfo[1].Trim();
                    string date = studentInfo[2].Trim();
                    DateTime regDate = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student newStudent = new Student();
                    newStudent.Name = name;
                    newStudent.Email = email;
                    newStudent.RegistrationDate = regDate;
                    currentTown.Students.Add(newStudent);
                }

                input = Console.ReadLine();
            }

            List<Group> groups = new List<Group>();

            foreach (var town in towns)
            {
                IEnumerable<Student> townStudents = town.Students
                    .OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email);

                while (townStudents.Any())
                {
                    Group newGroup = new Group();
                    newGroup.Town = town;
                    newGroup.Students = townStudents.Take(newGroup.Town.LabCapacity).ToList();
                    townStudents = townStudents.Skip(newGroup.Town.LabCapacity);
                    groups.Add(newGroup);
                }    
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Select(x => x.Name).Distinct().ToList().Count} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.Write("{0} => ", group.Town.Name);
                string emails = "";
                foreach (var student in group.Students)
                {
                    emails +=  student.Email + ", ";
                }
                emails = emails.TrimEnd(new char[] { ' ', ',' });
                Console.WriteLine(emails);
            }
        }
    }

    class Town
    {
        public string Name { get; set; }
        public int LabCapacity { get; set; }
        public List<Student> Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
