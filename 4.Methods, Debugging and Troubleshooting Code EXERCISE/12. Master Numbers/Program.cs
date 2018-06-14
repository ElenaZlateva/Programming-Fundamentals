using System;

namespace _12._Master_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string numToString = i.ToString();
              
                if (IsPalindrome(numToString, i) == true &&
          SumOfDigits(numToString, i) == true &&
          EvenDigit(numToString, i)== true)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        static bool IsPalindrome(string numToString, int i)
        {
            bool isPalindrome = true;
            string resultEndtoMid = "";
            char symbolEnd = '\0';
            for (int j = numToString.Length - 1; j >= 0; j--)
            {
                symbolEnd = numToString[j];
                resultEndtoMid += symbolEnd;

            }

            string resultBeginningToMid = "";
            char symbolBeg = '\0';
            for (int k = 0; k <= numToString.Length - 1; k++)
            {
                symbolBeg = numToString[k];
                resultBeginningToMid += symbolBeg;

            }
            if (resultBeginningToMid == resultEndtoMid)
            {
                isPalindrome = true;

            }
            else
            {
                isPalindrome = false;

            }
            return isPalindrome;
        }
        static bool SumOfDigits(string numToString, int i)
        {
            int numberOfDigits = numToString.Length;
            int sumOfDigits = 0;
            int lastDigit = 0;
            for (int l = 1; l <= numberOfDigits; l++)
            {
                lastDigit = i % 10;
                sumOfDigits += lastDigit;
                i = i / 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        static bool EvenDigit(string numToString, int i)
        {
            int numberOfDigits = numToString.Length;
            int lastDigit = 0;
            for (int m = 1; m <= numberOfDigits; m++)
            {
                lastDigit = i % 10;
                i = i / 10;
                if (lastDigit % 2 == 0)
                {
                    return true;

                }

            }
            return false;
        }
    }
}

