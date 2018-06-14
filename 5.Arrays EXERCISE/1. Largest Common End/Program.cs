using System;

namespace _1._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int counterLeft = 0;
            int counterRight = 0;
            for (int i = 0; i < Math.Min(firstInput.Length, secondInput.Length); i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    counterLeft++;
                }
                if (firstInput[firstInput.Length - 1 - i] == secondInput[secondInput.Length - 1 - i])
                {
                    counterRight++;
                }
            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}
