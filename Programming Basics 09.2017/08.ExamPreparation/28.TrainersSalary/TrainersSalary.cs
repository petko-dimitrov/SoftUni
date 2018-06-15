using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double paymentPerLecture = budget / lectures;
            double jelev = 0.0;
            double royal = 0.0;
            double roli = 0.0;
            double trofon = 0.0;
            double sino = 0.0;
            double others = 0.0;

            for (int i = 0; i < lectures; i++)
            {
                string lecturer = Console.ReadLine();
                switch (lecturer)
                {
                    case "Jelev": jelev += paymentPerLecture; break;
                    case "RoYaL": royal += paymentPerLecture; break;
                    case "Roli": roli += paymentPerLecture; break;
                    case "Trofon": trofon += paymentPerLecture; break;
                    case "Sino": sino += paymentPerLecture; break;
                    default: others += paymentPerLecture; break;
                }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", jelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royal);
            Console.WriteLine("Roli salary: {0:f2} lv", roli);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofon);
            Console.WriteLine("Sino salary: {0:f2} lv", sino);
            Console.WriteLine("Others salary: {0:f2} lv", others);
        }
    }
}
