using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i <= n; i++)
            {
                string numToString = i.ToString();


                int numberOfDigits = numToString.Length;
                int lastDigit = 0;
                for (int m = 1; m <= numberOfDigits; m++)
                {
                    lastDigit = i % 10;
                    i /= 10;
                    if (lastDigit % 2 == 0)
                    {
                        Console.WriteLine("even");

                    }

                }
                Console.WriteLine("even");
            }
        }
    }
}

