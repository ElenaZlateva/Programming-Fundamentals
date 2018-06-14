using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {

                string[] command = Console.ReadLine().Split();



                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    input.Insert(position, element);


                }

                else if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        input.Remove(element);
                        
                    }
                }

                else if (command[0] == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write(input[i] + " ");
                        }

                    }
                    return;

                }
                else if (command[0] == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write(input[i] + " ");
                        }

                    }
                    return;

                }

            }
        }
    }
}



