using System;

namespace _2.Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string job = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (job)
            {
                case "Athlete":
                    totalPrice = quantity * 0.7;

                    break;

                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantity * 1;


                    break;

                case "SoftUni Student":
                    totalPrice = quantity * 1.7;


                    break;


                default:
                    totalPrice = quantity * 1.2;

                    break;


            }
            Console.WriteLine($"The {job} has to pay {totalPrice:F2}.");
        }
    }
}
