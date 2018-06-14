using System;

namespace AddTwoNumbers_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = number1 + number2;
            //Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
            Console.WriteLine($"{number1} + {number2} = {sum}");

            }
        }
    }




