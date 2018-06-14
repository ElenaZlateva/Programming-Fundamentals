using System;
using System.Linq;

namespace _5._Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split().Select(double.Parse).ToArray();

            foreach (var item in numbers)
            {
                int roundNumber =(int) Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{item} => {roundNumber}");
            }

        }
    }
}
