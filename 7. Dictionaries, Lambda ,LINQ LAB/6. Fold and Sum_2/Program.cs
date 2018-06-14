using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Fold_and_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int size = input.Count / 4;
            int[]topLeft = input.Take(size).Reverse().ToArray();
            int[]topRight = input.Take(size).Reverse().ToArray();
            int[]bottom = input.Skip(size).Take(size * 2).ToArray();
            int[] top = topLeft.Concat(topRight).ToArray();
            

            var sum = top.Select((element, i) => element + bottom[i]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
