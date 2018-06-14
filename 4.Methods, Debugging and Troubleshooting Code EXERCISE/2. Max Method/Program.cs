using System;

namespace _2._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = 0;
            if (c>GetMax(a,b))
            {
                max = c;
            }
            else
            {
                max = GetMax(a,b);
            }
            Console.WriteLine(max);
        }
        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;

        }
    }
}
