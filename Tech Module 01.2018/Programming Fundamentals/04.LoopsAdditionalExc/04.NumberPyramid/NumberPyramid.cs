using System;

namespace _04.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int colLength = 1;

            while (count <= n)
            {
                for (int col = 1; col <= colLength; col++)
                {
                    Console.Write(count + " ");
                    count++;
                    if (count > n)
                    {
                        break;
                    }
                }
                colLength++;
                Console.WriteLine();
            }
        }
    }
}
