using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            char fourthLetter = char.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int count = -1;

            for (char s1 = 'A'; s1 <= firstLetter; s1++)
            {
                for (char s2 = 'a'; s2 <= secondLetter; s2++)
                {
                    for (char s3 = 'a'; s3 <= thirdLetter; s3++)
                    {
                        for (char s4 = 'a'; s4 <= fourthLetter; s4++)
                        {
                            for (int s5 = 0; s5 <= digit; s5++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
