using System;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> output = new Dictionary<string, int>();
            List<string> oddOutput = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.ContainsKey(input[i]))
                {
                    output.Add(input[i], 1);
                }
                else
                {
                    output[input[i]]++;//value
                }

            }

            foreach (var key in output)
            {
                if (key.Value % 2 != 0)
                {
                    oddOutput.Add(key.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddOutput));
        }
    }
}
