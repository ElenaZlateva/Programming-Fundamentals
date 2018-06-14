using System;

namespace _7.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)

        {
            int counter = 0;
            string input = Console.ReadLine();

            while (input != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
