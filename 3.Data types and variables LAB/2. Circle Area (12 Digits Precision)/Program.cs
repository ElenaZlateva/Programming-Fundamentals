using System;

namespace _2._Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double result = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"{result:f12}");
           //or Console.WriteLine("{0:f12}",result);

        }
    }
}
