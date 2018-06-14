using System;

namespace _4._Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            int num = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine(num);
        }
    }
}
