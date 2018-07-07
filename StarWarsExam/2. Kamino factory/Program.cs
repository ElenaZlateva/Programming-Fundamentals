using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string DNA = Console.ReadLine();
            int currentSequenceIndex = 0;
            int currentSequenceSum = 0;
            int bestSequenceIndex = 1;
            int bestSequenceSum = 0;
            int currentTotal1sum = 0;
            int[] bestDNASequence = new int[length];
            int startIndex = 0;
            int smallestStartIndex = 101;
            List<int> total1sumsListForEquals = new List<int>();


            while (DNA != "Clone them!")
            {
                int[] DNAsequence = DNA.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentSequenceSum = 1;
                currentTotal1sum = DNAsequence.Sum();



                for (int i = 0; i < length - 1; i++)
                {


                    currentSequenceIndex = i + 1;

                    if (DNAsequence[i] == 1) //&& DNAsequence[i + 1] == 1)
                    {
                        currentSequenceSum++;
                        startIndex = i;

                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestDNASequence = DNAsequence;
                        }
                        else if (currentSequenceSum == bestSequenceSum && startIndex < smallestStartIndex)
                        {
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestDNASequence = DNAsequence;
                        }
                        else if (currentSequenceSum == bestSequenceSum && startIndex == smallestStartIndex)
                        {
                            total1sumsListForEquals.Add(currentTotal1sum);
                            bestSequenceSum = total1sumsListForEquals.Max();
                            bestSequenceIndex = total1sumsListForEquals.IndexOf(bestSequenceSum) + 1;
                        }
                    }





                }

                DNA = Console.ReadLine();

            }


            Console.WriteLine($"Best DNA sample { bestSequenceIndex} with sum: { bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDNASequence));
        }
    }
}
