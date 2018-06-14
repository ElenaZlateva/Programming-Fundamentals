using System;
using System.Linq;

namespace Reading_Array_Values_from_a_Single_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //int[] numbers = new int[data.Length];

            //for (int i = 0; i < data.Length; i++)
            //{
            //    numbers[i] = int.Parse(data[i]);
            //}

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var inputLine = Console.ReadLine();
            //string[] items = inputLine.Split(' ');
            //int[] arr = items.Select(int.Parse).ToArray();


        }
    }
}
