using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.Write("centimeters = ");
            Console.WriteLine(centimeters);
            


        }
    }
}
