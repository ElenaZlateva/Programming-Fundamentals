using System;

namespace _1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            double maxValue = 0;
            int sbSnowMax=0;
            int sbTimeMax=0;
            int sbQualityMax=0;

            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                int sbSnow = int.Parse(Console.ReadLine());
                int sbTime = int.Parse(Console.ReadLine());
                int sbQuality = int.Parse(Console.ReadLine());

                double sbValue = Math.Pow((sbSnow / sbTime), sbQuality);

                if (sbValue > maxValue)
                {
                    maxValue = sbValue;
                    sbSnowMax = sbSnow;
                    sbTimeMax = sbTime;
                    sbQualityMax = sbQuality;
                }
            }

            Console.WriteLine($"{sbSnowMax} : {sbTimeMax} = {maxValue} ({sbQualityMax})");


        }
    }
}
