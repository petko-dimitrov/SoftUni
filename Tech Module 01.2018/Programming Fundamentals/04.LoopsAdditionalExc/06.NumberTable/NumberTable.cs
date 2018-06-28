using System;

namespace _06.NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool addIsPossible = true;

            for (int row = 1; row <= n; row++)
            {
                counter = row;
                addIsPossible = true;

                for (int col = 1; col <= n; col++)
                {
                    Console.Write(counter + " ");

                    if (addIsPossible && counter < n)
                    {
                        counter++;
                    }
                    else if (counter == n)
                    {
                        addIsPossible = false;
                        counter--;
                    }
                    else
                    {
                        counter--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
