using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExternalEvaluation
{
    class ExternalEvaluation
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double poor = 0.0;
            double satisfactory = 0.0;
            double good = 0.0;
            double veryGood = 0.0;
            double excellent = 0.0;

            for (int i = 0; i < students; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (points < 22.5)
                {
                    poor++;
                }
                else if (points < 40.5)
                {
                    satisfactory++;
                }
                else if (points < 58.5)
                {
                    good++;
                }
                else if (points < 76.5)
                {
                    veryGood++;
                }
                else
                {
                    excellent++;
                }
            }

            poor = poor / students * 100;
            satisfactory = satisfactory / students * 100;
            good = good / students * 100;
            veryGood = veryGood / students * 100;
            excellent = excellent / students * 100;

            Console.WriteLine("{0:f2}% poor marks", poor);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactory);
            Console.WriteLine("{0:f2}% good marks", good);
            Console.WriteLine("{0:f2}% very good marks", veryGood);
            Console.WriteLine("{0:f2}% excellent marks", excellent);
        }
    }
}
