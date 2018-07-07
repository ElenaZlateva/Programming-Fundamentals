using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace _2._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();
            string lessonTitle = null;
            int index = 0;

            while (command != "course start")
            {
                string[] commandToArr = command.Split(":").ToArray();

                if (commandToArr[0] == "Add")
                {
                    lessonTitle = commandToArr[1];
                    if (!initialSchedule.Contains(commandToArr[1]))
                    {
                        initialSchedule.Add(commandToArr[1]);
                    }

                }
                else if (commandToArr[0] == "Insert")
                {
                    lessonTitle = commandToArr[1];
                    index = int.Parse(commandToArr[2]);
                    if (index <= initialSchedule.Count && !initialSchedule.Contains(lessonTitle))
                    {
                        initialSchedule.Insert(index, lessonTitle);
                    }

                }
                else if (commandToArr[0] == "Remove")
                {
                    lessonTitle = commandToArr[1];
                    if (initialSchedule.Contains(lessonTitle))
                    {
                        initialSchedule.Remove(lessonTitle);
                    }

                    if (initialSchedule.Contains($"{lessonTitle}-Exercise"))
                    {
                        initialSchedule.Remove($"{lessonTitle}-Exercise");
                    }
                }
                else if (commandToArr[0] == "Swap")
                {
                    string lesson1 = commandToArr[1];
                    string lesson2 = commandToArr[2];
                    int indexOfLesson1 = 0;
                    int indexOfLesson2 = 0;

                    if (initialSchedule.Contains(lesson1) && initialSchedule.Contains(lesson2))
                    {
                        indexOfLesson1 = initialSchedule.IndexOf(lesson1);
                        indexOfLesson2 = initialSchedule.IndexOf(lesson2);
                        string copyOfLesson1 = lesson1;
                        string copyOfLesson2 = lesson2;
                        initialSchedule[indexOfLesson1] = copyOfLesson2;
                        initialSchedule[indexOfLesson2] = copyOfLesson1;

                        indexOfLesson1 = initialSchedule.IndexOf(lesson1);
                        indexOfLesson2 = initialSchedule.IndexOf(lesson2);

                        if (initialSchedule.Contains(($"{lesson1}-Exercise")))
                        {
                            initialSchedule.Remove($"{lesson1}-Exercise");
                            initialSchedule.Insert(indexOfLesson1 + 1, $"{lesson1}-Exercise");

                        }

                        if (initialSchedule.Contains(($"{lesson2}-Exercise")))
                        {
                            initialSchedule.Remove($"{lesson2}-Exercise");
                            initialSchedule.Insert(indexOfLesson2 + 1, $"{lesson2}-Exercise");
                        }

                    }
                }
                else if (commandToArr[0] == "Exercise")
                {
                    lessonTitle = commandToArr[1];

                    if (initialSchedule.Contains(lessonTitle) && !initialSchedule.Contains($"{lessonTitle}-Exercise"))
                    {
                        int indexOfLesson = initialSchedule.IndexOf(lessonTitle);
                        initialSchedule.Insert(indexOfLesson + 1, $"{lessonTitle}-Exercise");

                    }
                    else if (!initialSchedule.Contains(lessonTitle))
                    {
                        initialSchedule.Add(lessonTitle);
                        initialSchedule.Add($"{lessonTitle}-Exercise");

                    }

                }

                command = Console.ReadLine();
            }

            for (int i = 1; i <= initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i}.{ initialSchedule[i - 1]}");
            }

        }
    }
}
