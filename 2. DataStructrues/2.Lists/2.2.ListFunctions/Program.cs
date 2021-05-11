using System;
using System.Collections.Generic;

// Program Name; ListFunctions
// Program Description: This program demonstrates the functions of the list

namespace _2._2.ListFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] newItemsToAdd = new int[4];

            newItemsToAdd[0]=20;
            newItemsToAdd[1]=30;
            newItemsToAdd[2]=40;
            newItemsToAdd[3]=50;

            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(5);
            numberList.Add(6);
            numberList.Add(7);
            numberList.Add(5);
            numberList.Add(8);
            numberList.Add(9);

            // PrintList(numberList);

            // System.Console.WriteLine("List Remove function");
            // numberList.Remove(3);
            PrintList(numberList);
            System.Console.WriteLine();


            // System.Console.WriteLine("List RemoveAt function");
            // numberList.RemoveAt(4);
            // PrintList(numberList);
            // System.Console.WriteLine();

            

            // System.Console.WriteLine("List Count function");

            // System.Console.WriteLine("List Count is " + numberList.Count);
            // System.Console.WriteLine();


            // System.Console.WriteLine("List Capacity function");

            // System.Console.WriteLine("List Capacity is " + numberList.Capacity);
            // System.Console.WriteLine();
            
            
            // System.Console.WriteLine("List Contains function");

            // System.Console.WriteLine("List Contains 9 " + numberList.Contains(9));
            // System.Console.WriteLine("List Contains 19 " + numberList.Contains(19));
            // System.Console.WriteLine();

            // System.Console.WriteLine("List FindAll function");
            foreach(int val in numberList.FindAll(num => num.Equals(5)))
            {
                System.Console.WriteLine(val);
            }


            numberList.InsertRange(5,newItemsToAdd);
            
            PrintList(numberList);

        }

        // Function to print items in a list that is passed as an input
        static void PrintList(List<int> inputList)
        {
            System.Console.WriteLine("Printing from inputList");

            foreach (int number in inputList)
            {
                System.Console.WriteLine(number);
            }
        }
    }

    class Temp
    {
        int[] temArray= new int[6];
        private int _size = 0;

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Add(int number)
        {
            //current index
            //add to list
            _size++;
        }

        public void Remove(int number)
        {
            _size--;
        }
    }
}
