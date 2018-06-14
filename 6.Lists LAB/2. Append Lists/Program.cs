using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> output = new List<int>();            
            char[] inputInChars = Console.ReadLine().ToCharArray();
            int counterOfListsSeparators = 0;

            for (int i = 0; i < inputInChars.Length; i++)
            {
                if (inputInChars[i]=='|')
                {
                    counterOfListsSeparators++;
                }
            }

            for (int i = 0; i <=counterOfListsSeparators; i++)
            {

            }
            
        }
    }
}
