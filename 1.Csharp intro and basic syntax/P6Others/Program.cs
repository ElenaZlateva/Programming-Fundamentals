using System;

namespace P6Others
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {3:D4} {4:D4}", num1, num2, num3, num4);
            //Console.WriteLine($"{num1:D4} {num2:D4} {num2:D4} {num2:D4}");
        }
    }
}
