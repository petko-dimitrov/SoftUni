using System;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            int count = 0;
            char wrappingLetter = ' ';
            char firstLetter = ' ';
            char secondLetter = ' ';
            char thirdLetter = ' ';

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        count++;
                        if ((i + j + k) >= matchSum)
                        {
                            wrappingLetter = 'O';
                        }
                        else
                        {
                            wrappingLetter = 'X';
                        }
                        switch (i)
                        {
                            case 1:
                                firstLetter = 'A';
                                break;
                            case 2:
                                firstLetter = 'C';
                                break;
                            case 3:
                                firstLetter = 'G';
                                break;
                            case 4:
                                firstLetter = 'T';
                                break;
                            default:
                                break;
                        }
                        switch (j)
                        {
                            case 1:
                                secondLetter = 'A';
                                break;
                            case 2:
                                secondLetter = 'C';
                                break;
                            case 3:
                                secondLetter = 'G';
                                break;
                            case 4:
                                secondLetter = 'T';
                                break;
                            default:
                                break;
                        }
                        switch (k)
                        {
                            case 1:
                                thirdLetter = 'A';
                                break;
                            case 2:
                                thirdLetter = 'C';
                                break;
                            case 3:
                                thirdLetter = 'G';
                                break;
                            case 4:
                                thirdLetter = 'T';
                                break;
                            default:
                                break;
                        }
                        Console.Write($"{wrappingLetter}{firstLetter}{secondLetter}{thirdLetter}{wrappingLetter} ");
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
               
            }
        }
    }
}
