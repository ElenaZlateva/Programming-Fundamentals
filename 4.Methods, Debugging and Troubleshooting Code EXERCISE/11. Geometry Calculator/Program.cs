using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

           
            switch (figureType)
            {
                case "triangle":
                    double a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    TriangleArea(a, h);
                    return;

                case "rectangle":
                   double b = double.Parse(Console.ReadLine());
                   double c = double.Parse(Console.ReadLine());
                    RectangleArea(b, c);
                    return;

                case "square":
                   double d = double.Parse(Console.ReadLine());
                    SquareArea(d);
                    return;

                case "circle":
                   double r = double.Parse(Console.ReadLine());
                    CircleArea(r);
                    return;



            }
        }

        static void TriangleArea(double a, double h)
        {
            double triangleArea = a * h / 2;
            Console.WriteLine($"{triangleArea:f2}");
        }
        static void SquareArea(double d)
        {
            double squareArea = Math.Pow(d,2);
            Console.WriteLine($"{squareArea:f2}");
        }
        static void CircleArea(double r)
        {
            double circleArea = Math.PI * (Math.Pow(r, 2));
            Console.WriteLine($"{circleArea:f2}");
        }

        static void RectangleArea(double b, double c)
        {
            double rectangleArea = b * c;
            Console.WriteLine($"{rectangleArea:f2}");


        }
    }
}
