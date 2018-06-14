using System;

namespace _13.Game_of_Numbers// пререши!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int num = 0;
            int counter = 0;
            string result = "";
            bool isFound = false;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    counter++;

                    if ((i+j) ==magic)
                    {
                        isFound = true;
                        num = i + j;
                        result = ($"{i} + {j}");
                        

                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {result} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
           
        }
        
    }
}
