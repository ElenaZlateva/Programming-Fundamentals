using System;

namespace _9.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine($"{number} X {count} = {number * count}");

                count++;

            }
        }
    }
}
