using System;

namespace _1._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            WriteName(name);
        }
        static void WriteName (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
