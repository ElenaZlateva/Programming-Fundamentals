using System;

namespace _9.Count_the_integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            while (true)//infinite cycle
            {
                counter++;

                try
                {
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine(counter - 1);
                    return;
                }
            }
        }
    }
}
