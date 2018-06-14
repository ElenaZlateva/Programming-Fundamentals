using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Append_Lists_Alen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').Reverse().ToList();
            //[0] - 1 2 3 
            //[1]- 4 5 6 
            //[2] -   7  8// reverses them, so [2][1][0]
            List<string> result = new List<string>();
            

           
            for (int i = 0; i < input.Count; i++)
            {
                string text = input[i];//1 2 3 
                string[] splitted = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string merged = string.Join(" ", splitted);

                result.Add(merged);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
