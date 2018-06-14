using System;
using System.Linq;

namespace _3._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] middlePart = new int[numbers.Length / 2];
            int[] BegAndEndPart = new int[numbers.Length / 2];

            int startIndex = numbers.Length / 4;

            for (int i = 0; i < middlePart.Length; i++)
            {
                middlePart[i] = numbers[startIndex];
                startIndex++;

            }

            startIndex = numbers.Length / 4;
            for (int j = 0; j < BegAndEndPart.Length / 2; j++)
            {
                BegAndEndPart[j] = numbers[startIndex - 1 - j];

            }
            

            startIndex = numbers.Length - 1;
            for (int k = BegAndEndPart.Length / 2 ; k <= BegAndEndPart.Length - 1; k++)
            {
                BegAndEndPart[k] = numbers[startIndex];
                startIndex--;
            }

            int[] sum = new int[numbers.Length / 2];
            for (int l = 0; l < sum.Length; l++)
            {
                sum [l]= middlePart[l] + BegAndEndPart[l];
            }

            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
