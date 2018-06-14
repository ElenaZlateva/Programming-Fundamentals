using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 5;
            Increment(num, 15);
           // Console.WriteLine(num);

        }
            private static void Increment(int num, int value)
            {
                num += value;
            Console.WriteLine(num);
            }

        
    }
}

