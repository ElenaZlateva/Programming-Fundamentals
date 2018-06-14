using System;

namespace _1._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCenturies = int.Parse(Console.ReadLine());
            int years = numOfCenturies * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",numOfCenturies,years,days,hours,minutes);
        }
    }
}
