using System;
using System.Collections.Generic;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> grades = new Disctionary<string, double>();
            grades.Add("Mariq", 6.00);
            grades.Add("Pesho", 5.00);
            grades.Add("Gosho", 4.00);
            grades.Add("Stamat", 6.00);
            grades["Pesho"] = 3.00;

            foreach (var person in grades.Keys)
            {
                Console.WriteLine($"{person};");
            }
            foreach (var person in grades.Values)
            {
                Console.WriteLine($"{person:F2};");
            }

            foreach (var person in grades)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
