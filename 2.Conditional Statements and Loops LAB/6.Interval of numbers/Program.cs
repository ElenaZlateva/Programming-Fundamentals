using System;

namespace _6.Interval_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            for (int i = min; i <= max; i++)
                Console.WriteLine(i);
            {

            }

        }

    }
}

