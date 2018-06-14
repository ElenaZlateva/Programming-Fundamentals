using System;

namespace _8.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngredients = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 1; i <= numIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {

                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;

                    case "salami":
                        totalCalories += 600;
                        break;

                    case "pepper":
                        totalCalories += 50;
                        break;

              
                }
               
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
