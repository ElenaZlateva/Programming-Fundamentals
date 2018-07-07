using System;

namespace _1._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1Eff = int.Parse(Console.ReadLine());//students per hour
            int employee2Eff = int.Parse(Console.ReadLine());
            int employee3Eff = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int breakhours = 0;

            int totalEff = employee1Eff + employee2Eff + employee3Eff;
            int totalWorkingHours = 0;


            while (students > totalEff)
            {

                totalWorkingHours++;
                students -= totalEff;

            }

            if (students > 0)
            {
                totalWorkingHours++;
            }


            breakhours = totalWorkingHours / 3;

            if (breakhours % 3 == 0 && students == 0)
            {
                breakhours--;
            }
            int totalTime = breakhours + totalWorkingHours;


            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}
