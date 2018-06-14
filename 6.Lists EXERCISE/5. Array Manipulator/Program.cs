using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (true)
            {

                if (input == "print")
                {
                    Console.WriteLine();
                    break;
                }

                string[] commandsArr = input.Split();
                string command = commandsArr[0];
                if (command == "add")
                {
                    int index = int.Parse(commandsArr[1]);
                    int element = int.Parse(commandsArr[2]);
                    inputList.Insert(index, element);
                }

                else if (command == "addMany")
                {
                    int index = int.Parse(commandsArr[1]);
                    List<int> elementsToInsert = new List<int>();

                    for (int i = 2; i < commandsArr.Length; i++)
                    {
                        elementsToInsert.Add(int.Parse(commandsArr[i]));
                    }
                    List<int> currentResult = new List<int>();
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] != index)
                        {
                            currentResult.Add(input[i]);
                        }
                        else
                        {
                            currentResult.AddRange(elementsToInsert);
                        }
                    }

                }

                else if (command == "contains")
                {
                    
                    if (inputList.Contains(int.Parse(commandsArr[1])))
                    {
                        for (int i = 0; i < inputList.Count; i++)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }

                }
                else if (command == "remove")
                {
                    int element = int.Parse(commandsArr[1]);
                    inputList.RemoveAt(element);
                }
                else if (command == "shift")
                {
                    int positions = int.Parse(commandsArr[1]);
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        inputList[positions] = inputList[positions - positions];
                    }
                }
                else if (command == "sumPairs")
                {

                }

            }
        }
    }
}
