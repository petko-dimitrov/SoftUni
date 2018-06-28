using System;
using System.Linq;

namespace _02.KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string dnaSequence = Console.ReadLine();

            int bestLength = 0;
            int bestStart = -1;
            int bestSum = 0;
            int bestSample = 1;
            int[] bestSequence = new int[sequenceLength];
            int currentSample = 0;


            while (dnaSequence != "Clone them!")
            {
                int[] currentSequence = dnaSequence
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currentSample++;
                int count = 0;
                int currentBestStart = 0;
                int currentBestLength = 0;
                int currentSum = currentSequence.Sum();

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        count++;
                    }

                    else
                    {
                        if (count > currentBestLength)
                        {
                            currentBestLength = count;
                            currentBestStart = i - currentBestLength;
                        }
                        count = 0;
                    }
                    if (i == currentSequence.Length - 1)
                    {
                        if (count > currentBestLength)
                        {
                            currentBestLength = count;
                            currentBestStart = i - currentBestLength + 1;
                        }
                    }
                }

                if (currentBestLength > bestLength)
                {
                    bestLength = currentBestLength;
                    bestStart = currentBestStart;
                    bestSum = currentSum;
                    bestSequence = currentSequence;
                    bestSample = currentSample;
                }
                else if (currentBestLength == bestLength)
                {
                    if (currentBestStart < bestStart)
                    {
                        bestLength = currentBestLength;
                        bestStart = currentBestStart;
                        bestSum = currentSum;
                        bestSequence = currentSequence;
                        bestSample = currentSample;
                    }
                    else if (currentBestStart == bestStart)
                    {
                        if (currentSum > bestSum)
                        {
                            bestLength = currentBestLength;
                            bestStart = currentBestStart;
                            bestSum = currentSum;
                            bestSequence = currentSequence;
                            bestSample = currentSample;
                        }
                    }
                }
                dnaSequence = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
