using System;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch (month)
            {

                case "May":
                case "October":

                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;

                    if (nightsCount > 7)
                    {
                        priceStudio = 0.95 * 50;
                    }
                    break;


                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;

                    if (nightsCount > 14)
                    {
                        priceDouble = 0.9 * 72;
                    }

                    break;

                case "July":
                case "August":
                case "December":

                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;

                    if (nightsCount > 14)
                    {
                        priceSuite = 0.85 * 89;
                    }
                    break;




                default:
                    break;
            }


            double totalPriceSuite = nightsCount * priceSuite;
            double totalPriceDouble = nightsCount * priceDouble;
            double totalPriceStudio = nightsCount * priceStudio;


            if (nightsCount > 7)
            {
                switch (month)
                {
                    case "September":


                        totalPriceStudio = (nightsCount - 1) * priceStudio;
                        break;

                    case "October":

                        totalPriceStudio = (nightsCount - 1) * priceStudio;
                        break;
                }
            }


            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
        }
    }
}
