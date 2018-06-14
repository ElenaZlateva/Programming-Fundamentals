using System;

namespace _12.Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = first; i >= 1; i--)
            {
                for (int j = 1; j <= second; j++)
                {
                    sum = sum + (3 * (i * j));
                    counter++;

                    if (sum >= third)
                    {
                        Console.WriteLine($"{ counter} combinations");
                        Console.WriteLine($"Sum: { sum} >= {third}");
                        return;

                    }
                }
                
            }
            Console.WriteLine($"{ counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
