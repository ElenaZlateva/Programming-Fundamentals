using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();


            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    output.Add(input[i]);

                }
            }

            output.Sort();
            output.Reverse();

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
