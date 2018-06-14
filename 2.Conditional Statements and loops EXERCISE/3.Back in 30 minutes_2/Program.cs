using System;

namespace _3.Back_in_30_minutes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;

            var allMinutes = hour * 60 + minutes;

            Console.WriteLine($"{allMinutes/60 % 24}:{allMinutes%60:D2}");

        }
    }
}
