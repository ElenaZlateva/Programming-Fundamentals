using System;

namespace _8.Sum_of_odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddNumber = 1;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;

            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
