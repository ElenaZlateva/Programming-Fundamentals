using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            double sum = 0;


            for (int j = 0; j < input.Count - 1; j++)
            {
                if (input[j] == input[j + 1])
                {
                    sum = input[j] + input[j + 1];
                    input.Insert(j, sum);
                    input.RemoveAt(j + 1);
                    input.RemoveAt(j + 1);
                    j = -1;

                }

            }
            
            Console.WriteLine(string.Join(" ", input));
        }

    }
}

