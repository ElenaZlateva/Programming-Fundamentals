using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string calcualteWhat = Console.ReadLine();

            switch (calcualteWhat)
            {
                case "face":
                    FaceDiagonal(side);
                    return;
                case "space":
                    SpaceDiagonals(side);
                    return;
                case "volume":
                   Volume(side);
                    return;
                case "area":
                    SurfaceArea(side);
                    return;
              
            }

        }
        static void FaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine($"{faceDiagonal:f2}");


        }

        static void SpaceDiagonals(double side) {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine($"{spaceDiagonal:f2}");

        }

        static void Volume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine(($"{volume:f2}"));
        }
        static void SurfaceArea(double side)
        {
            double surfaceArea = 6 * Math.Pow(side, 2);
            Console.WriteLine(($"{surfaceArea:f2}"));
        }

    }
}
