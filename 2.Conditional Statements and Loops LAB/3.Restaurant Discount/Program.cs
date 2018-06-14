using System;

namespace _3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageName = Console.ReadLine();
            string hallName = "";
            double price = 0;


            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price = 2500;

            }
            else if (groupSize <= 100)
            {

                hallName = "Terrace";
                price = 5000;

            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                price = 7500;

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (packageName)
            {

                case "Normal":

                    price += 500;
                    price -= price * 0.05;
                    break;

                case "Gold":

                    price += 750;
                    price -= price * 0.1;
                    break;
                case "Platinum":

                    price += 1000;
                    price -= price * 0.15;
                    break;


            }


            double pricePerPerson = price / groupSize;
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");

        }
    }
}
