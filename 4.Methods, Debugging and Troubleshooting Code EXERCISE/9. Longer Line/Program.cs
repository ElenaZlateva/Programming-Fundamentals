using System;

namespace _9._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LineLength(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        static void LineLength(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a1 = Math.Abs(x1) + Math.Abs(x2);
            double b1 = Math.Abs(y1) + Math.Abs(y2);
            double lineOne = Math.Pow(a1, 2) + Math.Pow(b1, 2);

            double a2 = Math.Abs(x3) + Math.Abs(x4);
            double b2 = Math.Abs(y3) + Math.Abs(y3);
            double lineTwo = Math.Pow(a2, 2) + Math.Pow(b2, 2);


            if (lineOne < lineTwo)
            {
                CloserToThe0Line2(x3, y3, x4, y4);

            }
            else
            {
                CloserToThe0Line1(x1, y1, x2, y2);
            }

        }
        static void CloserToThe0Line1(double x1, double y1, double x2, double y2)
        {
            decimal distance1 = (decimal)Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            decimal distance2 = (decimal)Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (distance1 > distance2)
            {
                Console.WriteLine($"({x2}, {y2}{x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1}{x2}, {y2})");

            }
        }

        static void CloserToThe0Line2(double x3, double y3, double x4, double y4)
        {
            decimal distance1 = (decimal)Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            decimal distance2 = (decimal)Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if (distance1 > distance2)
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
            else
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");

            }
        }
    }

}
