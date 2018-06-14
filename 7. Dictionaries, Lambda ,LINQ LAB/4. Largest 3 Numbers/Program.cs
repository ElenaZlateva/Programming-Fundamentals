using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.WriteLine(string.Join(" ", input.OrderByDescending(x => x).Take(3)));
        }
    }
}
