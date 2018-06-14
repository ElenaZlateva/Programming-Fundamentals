using System;

namespace _1.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);//0 = placeholder
            Console.WriteLine($"Hello, {name}!");//interpolation
            Console.WriteLine("Hello, "+ name +"!");


        }
    }
}
