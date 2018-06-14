using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> manipultedList = new List<int>();

            int takeNums = command[0];
            int deletedNums = command[1];
            int searchNum = command[2];

            for (int i = 0; i < takeNums; i++)
            {
                manipultedList.Add(inputNumbersList[i]);

            }
            for (int i = 0; i < deletedNums; i++)
            {
                manipultedList.RemoveAt(0);
            }

            if (manipultedList.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
