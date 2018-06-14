using System;

namespace Printing_on_the_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gosho";
            int age = 5;
            Console.WriteLine("Name: " + name + ", Age: " + age);//concatenation
            Console.WriteLine("Name: {0}, Age: {1}", name, age);//placeholders
            Console.WriteLine($"Name: {name}, Age: {age}");//itrapolation - podpyhvame dinamichna stoinost v skobite

        }
    }
}
