using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Thirt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPrice = 0;
            double totalIncome = 0;


            while (command != "end of shift")
            {
                string patternInput = @"(.*)%([A-Z][a-z]*)%(.*)<([a-zA-Z]*)>(.*)\|([0-9]*)\|[a-zA-Z\W]*([0-9]*\.?[0-9]*)\$(.*)";
                bool isAMatch = Regex.IsMatch(command, patternInput);

                if (isAMatch)
                {
                    Match match = Regex.Match(command, patternInput);

                    if (!match.Groups[1].Value.Contains('|') || !match.Groups[1].Value.Contains('$') || !match.Groups[1].Value.Contains('%') || !match.Groups[1].Value.Contains('.')
                      || !match.Groups[3].Value.Contains('|') || !match.Groups[3].Value.Contains('$') || !match.Groups[3].Value.Contains('%') || !match.Groups[3].Value.Contains('.')
                      || !match.Groups[5].Value.Contains('|') || !match.Groups[5].Value.Contains('$') || !match.Groups[5].Value.Contains('%') || !match.Groups[5].Value.Contains('.')
                       || !match.Groups[8].Value.Contains('|') || !match.Groups[8].Value.Contains('$') || !match.Groups[8].Value.Contains('%') || !match.Groups[8].Value.Contains('.'))
                    {

                        totalPrice = int.Parse(match.Groups[6].Value) * double.Parse(match.Groups[7].Value);
                        totalIncome += totalPrice;
                        Console.WriteLine($"{match.Groups[2]}: {match.Groups[4]} - {totalPrice:F2}");
                        command = Console.ReadLine();
                    }
                    else
                    {
                        command = Console.ReadLine();
                    }

                }
                else
                {
                    command = Console.ReadLine();
                }

            }

            Console.WriteLine($"Total income: {totalIncome:F2}");

        }
    }
}

