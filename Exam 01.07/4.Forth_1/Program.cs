using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace _4.Forth_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                string[] commandToArray = command.Split("-").ToArray();

                if (commandToArray[1] == "banned")
                {
                    results.Remove(commandToArray[0]);
                }
                else
                {


                    string name = commandToArray[0];
                    string language = commandToArray[1];
                    int points = int.Parse(commandToArray[2]);

                    if (results.ContainsKey(name))
                    {
                        if (results[name] < points)
                        {
                            results[name] = points;
                        }
                    }
                    else
                    {
                        results.Add(name, points);
                    }

                }

                string name = commandToArray[0];
                string language = commandToArray[1];
                int points = int.Parse(commandToArray[2]);

                if (submissions.ContainsKey(language))
                {
                    submissions[language]++;
                }
                else
                {
                    submissions.Add(language, 1);
                }

                command = Console.ReadLine();

            }


            Console.WriteLine("Results:");


            foreach (var pair in results.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key))
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submissions.OrderByDescending(item=>item.Value).ThenBy(item=>item.Key))
            {

            }
        }
    }
}
