using System;

namespace _5._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA": //will check them one by one and then will go to default
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;


                default:
                    Console.WriteLine("Unknown");
                    break;

            }
        }
    }
}
