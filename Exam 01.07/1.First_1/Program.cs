using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace _1.First_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1Eff = int.Parse(Console.ReadLine());//students per hour
            int employee2Eff = int.Parse(Console.ReadLine());
            int employee3Eff = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalEff = employee1Eff + employee2Eff + employee3Eff;
            int totalWorkingHours = (int)Math.Ceiling(students * 1.0 / totalEff * 1.0);
            int breakHours = totalWorkingHours / 3;
            int totalTime = totalWorkingHours + breakHours;

            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}
