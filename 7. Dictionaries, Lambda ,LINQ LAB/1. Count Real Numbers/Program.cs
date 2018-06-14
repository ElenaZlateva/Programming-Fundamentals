using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> output = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.ContainsKey(input[i]))
                {
                    output.Add(input[i], 1);
                }
                else
                {
                    output[input[i]]++;
                }

            }
            foreach (var num in output)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
            
        }
    }
}
