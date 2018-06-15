using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int examinedPatients = 0;
            int unexaminedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unexaminedPatients > examinedPatients)
                {
                    doctors++;
                }
                if (patients <= doctors)
                {
                    examinedPatients += patients;
                }
                else
                {
                    examinedPatients += doctors;
                    unexaminedPatients += patients - doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.", examinedPatients);
            Console.WriteLine("Untreated patients: {0}.", unexaminedPatients);
        }
    }
}
