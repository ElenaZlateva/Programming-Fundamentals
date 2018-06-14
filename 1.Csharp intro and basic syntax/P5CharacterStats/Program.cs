using System;

namespace P5CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currenthealth = int.Parse(Console.ReadLine());
            int maxhealth = int.Parse(Console.ReadLine());
            int currentenergy = int.Parse(Console.ReadLine());
            int maxenergy = int.Parse(Console.ReadLine());

            //Console.WriteLine("Health: |" + new string('|', currenthealth)
            //    + new string('.', maxhealth - currenthealth) + "|");

            //Console.WriteLine($"Energy: | {new string}")

            Console.WriteLine("Name: " + name);
            Console.Write("Health: |");
            for (int i = 0; i < maxhealth; i++)
            {
                if (currenthealth - i > 0)
                {
                    Console.Write("|");
                }
                else
                    Console.Write(".");

            }



        }
    }
}
