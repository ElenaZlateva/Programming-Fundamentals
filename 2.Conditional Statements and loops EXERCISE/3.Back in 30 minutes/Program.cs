using System;

namespace _3.Back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hour++;
                minutes -= 60;

            }

            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");

        }
    }
}
