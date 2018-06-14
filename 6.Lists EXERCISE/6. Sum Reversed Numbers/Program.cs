using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                List<char> num = input[i].ToString().ToList();
                num.Reverse();
                sum += int.Parse(string.Join("", num));
            }
            Console.WriteLine(sum);

        }
    }
}
