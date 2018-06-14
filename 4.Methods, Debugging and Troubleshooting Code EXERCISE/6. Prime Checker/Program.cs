using System;

namespace _6._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            bool isPrime = false;

            if (n==2)
            {
                Console.WriteLine(!isPrime);
                return;
            }
            else if (n==0 || n==1)
            {
                Console.WriteLine(isPrime);
                return;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(isPrime);
                    return;
                }
            }
            Console.WriteLine(!isPrime);
        }
    }
}
