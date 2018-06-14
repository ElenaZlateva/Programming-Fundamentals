using System;
using System.Linq;

namespace _6._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestLength = 0;
            int currLength = 1;
            int bestInt = 0;

            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i - 1] == intArr[i])
                {
                    currLength++;

                    if (currLength>bestLength)
                    {
                        bestInt = intArr[i];
                        bestLength = currLength;
                    }
                    
                }
                else
                {
                    currLength = 1;
                }
                

            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write($"{bestInt}" + " ");
            }
            Console.WriteLine();

        }
    }
}
