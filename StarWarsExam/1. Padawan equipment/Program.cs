using System;

namespace _1._Padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double totalPriceOfEquipment = 0;
            double totalsabresPrice = Math.Ceiling(students*1.1) * sabrePrice;
            double totalrobesPrice = students * robePrice;
            int freebelts = students/6;           
            double totalbeltsPrice = (students-freebelts)*beltPrice;

            totalPriceOfEquipment = totalbeltsPrice + totalrobesPrice + totalsabresPrice;

            if (totalPriceOfEquipment<=money)
            {
                Console.WriteLine($"The money is enough - it would cost { totalPriceOfEquipment:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPriceOfEquipment-money):F2}lv more.");
            }
        }
    }
}
