using System;

namespace _5._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string TF = Console.ReadLine();
            bool boolValue = Convert.ToBoolean(TF);
            if (boolValue==true)
            {
                Console.WriteLine("Yes");
            }
            else if (boolValue == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
