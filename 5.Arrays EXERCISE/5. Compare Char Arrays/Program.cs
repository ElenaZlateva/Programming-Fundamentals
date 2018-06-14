using System;
using System.Linq;

namespace _5._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            bool arr1PrintFirst = false;


            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] > arr2[i])
                {
                    arr1PrintFirst = false;
                    break;

                }
                else if (arr1[i] < arr2[i])
                {
                    arr1PrintFirst = true;
                    break;
                }
                else if (i == Math.Min(arr1.Length, arr2.Length) - 1)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        arr1PrintFirst = false;

                    }
                    else if (arr1.Length <= arr2.Length)
                    {
                        arr1PrintFirst = true;
                    }
                }


            }
            if (arr1PrintFirst)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }



        }



    }
}

