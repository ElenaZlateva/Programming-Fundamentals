using System;

namespace P4BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentper100ml = int.Parse(Console.ReadLine());
            double sugarContentper100 = double.Parse(Console.ReadLine());

            double volumeDivby100 = volume / 100.0;

            double energyTotal = energyContentper100ml * volumeDivby100;
            double sugarTotal = sugarContentper100 * volumeDivby100;
            
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyTotal}kcal, {sugarTotal}g sugars");


        }
    }
}
