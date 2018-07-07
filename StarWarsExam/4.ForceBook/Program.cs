using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternPipe = @"(.*)\s\|\s(.*)";
            string patternArrow = @"(.*)\s->\s(.*)";
            Dictionary<string, string> forceBook = new Dictionary<string, string>();
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
            string forceSide;
            string forceUser;


            while (input != "Lumpawaroo")
            {
                bool ifMatchesPipe = Regex.IsMatch(input, patternPipe);
                if (ifMatchesPipe)
                {

                    Regex regexPipe = new Regex(patternPipe);
                    Match matchPipe = regexPipe.Match(input);
                    forceSide = matchPipe.Groups[1].ToString();
                    forceUser = matchPipe.Groups[2].ToString();

                    if (!forceBook.ContainsKey(forceUser))
                    {
                        forceBook.Add(forceUser, forceSide);
                    }

                }

                bool ifMatchesArrow = Regex.IsMatch(input, patternArrow);
                if (ifMatchesArrow)
                {
                    Regex regexArrow = new Regex(patternArrow);
                    Match matchArrow = regexArrow.Match(input);
                    forceSide = matchArrow.Groups[2].ToString();
                    forceUser = matchArrow.Groups[1].ToString();

                    if (!forceBook.ContainsKey(forceUser))
                    {
                        forceBook.Add(forceUser, forceSide);
                    }
                    else
                    {
                        forceBook[forceUser] = forceSide;
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var pair in forceBook)
            {
                if (!output.ContainsKey(pair.Value))
                {
                    output.Add(pair.Value, new List<string> { pair.Key });
                }
                else
                {
                    output[pair.Value].Add(pair.Key);
                }
            }


           // output.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key); - wrong syntax!

            foreach (var pair in output.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                //  Console.WriteLine(string.Join("! ",output.Values.ToList()));

                Console.WriteLine("! " + string.Join("\n! ", output[pair.Key]));

                
            }
        }
    }
}
