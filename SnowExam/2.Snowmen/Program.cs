using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();



            if (input.Count > 2)

            {

                List<int> attacker = new List<int>();
                List<int> target = new List<int>();
                List<int> difference = new List<int>();

                for (int i = 0; i < input.Count; i++)
                {
                    attacker.Add(i);
                    target.Add(input[i] % input.Count);
                    difference.Add(Math.Abs(attacker[i] - target[i]));

                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (difference[i] == 0)
                    {
                        Console.WriteLine($"{attacker[i]} performed harakiri");
                        input.RemoveAt(attacker[i]);

                    }
                    else if (difference[i] % 2 != 0)
                    {
                        Console.WriteLine($"{attacker[i]} x {target[i]} -> {target[i]} wins");
                        input.RemoveAt(attacker[i]);

                    }
                    else if (difference[i] % 2 == 0)
                    {
                        Console.WriteLine($"{attacker[i]} x {target[i]} -> {attacker[i]} wins");
                        input.RemoveAt(target[i]);
                                            }
                }

            }
            if (input.Count == 2)
            {

                List<int> attacker = new List<int>();
                List<int> target = new List<int>();
                List<int> difference = new List<int>();

                for (int i = 0; i < input.Count; i++)
                {
                    attacker.Add(i);
                    target.Add(input[i] % input.Count);
                    difference.Add(Math.Abs(attacker[i] - target[i]));

                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (difference[i] == 0)
                    {
                        Console.WriteLine($"{attacker[i]} performed harakiri");
                        return;

                    }
                    else if (difference[i] % 2 != 0)
                    {
                        Console.WriteLine($"{attacker[i]} x {target[i]} -> {target[i]} wins");
                        return;

                    }
                    else if (difference[i] % 2 == 0)
                    {
                        Console.WriteLine($"{attacker[i]} x {target[i]} -> {attacker[i]} wins");
                        return;

                    }
                }

            }
            if (input.Count < 2)
            {
                return;
            }

        }
    }
}
