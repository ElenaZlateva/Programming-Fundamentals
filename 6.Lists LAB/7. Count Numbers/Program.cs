using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();

            int counter = 1;

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{input[i]} -> {counter}");
                    counter = 1;
                }
                
            }

            Console.WriteLine($"{input[input.Count-1]} -> {counter}");

        }
    }
}
