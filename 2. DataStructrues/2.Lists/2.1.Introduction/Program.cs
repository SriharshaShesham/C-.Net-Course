using System;
using System.Collections.Generic;

namespace _2.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("---------------------------------------------------------------------------");

            //List
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(6);
            numberList.Add(7);

            System.Console.WriteLine("Printing from List");

            foreach(int number in numberList)
            {
                System.Console.WriteLine(number);
            }

        }
    }
}
