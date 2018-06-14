using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(":.,:;()[]\" ' \\ /!? ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            var result = input.Distinct().Where(w => w.Length < 5).OrderBy(w => w);

            Console.WriteLine(string.Join(", ",result) );
            


        }
    }
}
