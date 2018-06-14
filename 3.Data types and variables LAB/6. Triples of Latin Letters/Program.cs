using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)(n + 'a');


            for (char i = 'a'; i < letter; i++)
            {
                for (char j = 'a'; i < letter; j++)
                {
                    for (char k = 'a'; i < letter; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
