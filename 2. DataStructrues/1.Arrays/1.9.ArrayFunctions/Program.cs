using System;

namespace _1._9.ArrayFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] numberArray= new int[9];
            numberArray[0]=1;
            numberArray[1]=2;
            numberArray[2]=3;
            numberArray[3]=6;

            System.Console.WriteLine("Printing from array");


            float floatingNumber=23.5f;

            System.Console.WriteLine("Array GetType function");
            System.Console.WriteLine($"{floatingNumber} -> Type -> {floatingNumber.GetType()}");
            
            foreach(int number in numberArray)
            {
                System.Console.WriteLine("Array CompareTo function");
                //CompareTo -> if val> input = 1; val < input = -1; val ==input = 0;
                System.Console.WriteLine($"{number} -> 3 -> {number.CompareTo(3)}");

                System.Console.WriteLine();

                System.Console.WriteLine("Array Equals function");
                System.Console.WriteLine($"{number} -> 3 -> {number.Equals(3)}");
                
                System.Console.WriteLine();
                
                System.Console.WriteLine("Array ToString function");
                System.Console.WriteLine($"{number} -> convert to string -> {(number.ToString()).GetType()}");
                
                
            }
        }
    }
}
