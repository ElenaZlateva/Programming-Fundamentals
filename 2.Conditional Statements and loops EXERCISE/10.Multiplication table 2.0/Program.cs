using System;

namespace _10.Multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {count} = {number * count}");
                count++;
            } while (count ++ < 10);


        }
    }
}
