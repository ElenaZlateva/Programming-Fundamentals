﻿using System;

namespace _12.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input!");
        }
    }
}
    }
