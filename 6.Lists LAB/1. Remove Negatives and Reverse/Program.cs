using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();

            foreach (var num in input)
            {
                if (num>=0)
                {
                    output.Add(num);
                }
            }

            if (output.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = output.Count-1; i >= 0; i--)
                {
                    Console.Write(output[i] + " " );
                }
                
            }

        }
    }
}
