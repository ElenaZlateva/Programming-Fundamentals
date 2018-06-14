using System;

namespace _5._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);



        }
        static void Fib(int n)
        {
            int numZero = 0;
            int numOne = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = numZero + numOne;
                numZero = numOne;
                numOne = sum;
            }


            Console.WriteLine(sum);

        }

    }
}
