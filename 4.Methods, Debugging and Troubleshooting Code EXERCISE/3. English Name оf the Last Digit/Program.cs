﻿using System;

namespace _3._English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(LastDigitName(num));

        }
        static string LastDigitName(string num)
        {
            char lastSymbol = num[num.Length - 1];
            string result = "";

            switch (lastSymbol)
            {
                case '0':
                    result = "zero";
                    break;
                case '1':
                    result = "one";
                    break;
                case '2':
                    result = "two";
                    break;
                case '3':
                    result = "three";
                    break;
                case '4':
                    result = "four";
                    break;
                case '5':
                    result = "five";
                    break;
                case '6':
                    result = "six";
                    break;
                case '7':
                    result = "seven";
                    break;
                case '8':
                    result = "eight";
                    break;
                case '9':
                    result = "nine";
                    break;
                default:
                    break;
            }
            return result;

        }
    }
}
