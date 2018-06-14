using System;

namespace _15.Neighbour_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int counterTurns = 1;
            int healthGosho = 100;
            int healthPesho = 100;


            while (true)
            {


                if (counterTurns % 2 != 0)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }

                }



                if (counterTurns % 2 == 0)
                {

                    healthPesho -= damageGosho;

                    if (healthPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }

                }


                if (healthGosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {counterTurns}th round.");
                    return;
                }
                else if (healthPesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {counterTurns}th round.");
                    return;
                }


                if (counterTurns % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
                counterTurns++;
            }

        }
    }
}
