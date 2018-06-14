using System;

namespace _2._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }


            int[] sum = new int[numbers.Length];
            for (int i = 0; i < k; i++)
            {
                int[] rotateElements = RotateArray(numbers);


                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += rotateElements[j];
                }

                numbers = rotateElements;
            }
            Console.WriteLine(string.Join(" ", sum));
        }




        static int[] RotateArray(int[] numbers)
        {
            int lastElement = numbers[numbers.Length - 1];
            int[] rotateElements = new int[numbers.Length];
            rotateElements[0] = lastElement;

            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                rotateElements[i] = numbers[i - 1];
            }
            return rotateElements;
        }
    }
}
