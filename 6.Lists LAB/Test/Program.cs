using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myFirstList = new List<int>();
            Console.WriteLine(myFirstList.Capacity);
            Console.WriteLine(myFirstList.Count);
            myFirstList.Add(10);
            myFirstList.Insert(1, 20);
            myFirstList.Remove(10);//accepts an object and removes it - int, "string", 'char'; returns bool - if it managed to delete the item or not; removes only the first
            // object that he meets
            myFirstList.RemoveAt(0);
            myFirstList.RemoveAll(x => x == 4);//removes all "4"s
            Console.WriteLine(myFirstList.Contains(7)); // returns true/false




        }
    }
}
