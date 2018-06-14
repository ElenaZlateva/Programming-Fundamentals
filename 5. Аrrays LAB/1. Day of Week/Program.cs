using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] dayOfTheWeek =
            {
                 "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            try
            {
                Console.WriteLine(dayOfTheWeek[dayNumber-1]);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
