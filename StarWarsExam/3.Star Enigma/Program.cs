using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterDecreaseChars = 0;
            List<string> destroyedPlanets = new List<string>();
            List<string> attackedPlanets = new List<string>();
            int attackedPlanetsCount = 0;
            int destroyedPlanetsCount = 0;


            for (int i = 0; i < n; i++)
            {

                string message = Console.ReadLine();
                string messageToLower = message.ToLower();
                char[] encryptedMessageToLower = messageToLower.ToCharArray();
                List<char> decryptedMessage = new List<char>();
                string decryptedMessageToString;

                foreach (var symbol in encryptedMessageToLower)
                {
                    if (symbol == 's' || symbol == 't' || symbol == 'a' || symbol == 'r')
                    {
                        counterDecreaseChars++;
                    }
                }

                for (int j = 0; j < message.Length; j++)
                {
                    decryptedMessage.Add((char)(message[j] - counterDecreaseChars));
                }

                counterDecreaseChars = 0;
                decryptedMessageToString = string.Join("", decryptedMessage);



                string validationPattern = @".*(@)([a-zA-z]*).*(:)([0-9]*).*(!)([A|D])(!).*(->)([0-9]*).*";
                bool validInput = Regex.IsMatch(decryptedMessageToString, validationPattern);


                if (validInput)
                {

                    string patternAttackPlanet = @".*(@)([a-zA-z]*).*(:)([0-9]*).*(!)([A])(!).*(->)([0-9]*).*";
                    string patternDestroyPlanet = @".*(@)([a-zA-z]*).*(:)([0-9]*).*(!)([D])(!).*(->)([0-9]*).*";

                    MatchCollection allMatchesAttack = Regex.Matches(decryptedMessageToString, patternAttackPlanet);
                    MatchCollection allMatchesDestroy = Regex.Matches(decryptedMessageToString, patternDestroyPlanet);

                    foreach (Match match in allMatchesAttack)
                    {
                        attackedPlanets.Insert(0,match.Groups[2].Value);
                        attackedPlanetsCount++;
                    }

                    foreach (Match match in allMatchesDestroy)
                    {
                        destroyedPlanets.Insert(0, match.Groups[2].Value);
                        destroyedPlanetsCount++;
                    }
                }
                
            }

            if (attackedPlanetsCount > 0)
            {
                Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
                Console.WriteLine("-> " + string.Join("\n-> ", attackedPlanets));
            }
            else
            {
                Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");

            }
            
            if (destroyedPlanetsCount > 0)
            {
                Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
                Console.WriteLine("-> " + string.Join("\n-> ", destroyedPlanets));
            }
            else
            {
                Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            }


        }
    }
}

