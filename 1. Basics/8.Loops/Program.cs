using System;

namespace _8.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication Table for a user given number.
            int number;
            number = GetANumberFromUser();

            // While Loop
            // WhileLoopPrintMultiplicationTable(number);

            // For Loop
            // ForLoopPrintMultiplicationTable(number);

            // Do While
            DoWhileLoopPrintMultiplicationTable(number);
        }

        static int GetANumberFromUser()
        {
            System.Console.WriteLine("Please enter a number");
            return Convert.ToInt16(Console.ReadLine());
        }


        static void WhileLoopPrintMultiplicationTable(int number)
        {
            // Initialization
            int maxNum = 10;
            int minNum = 1;

            //Check COndition
            while (minNum <= maxNum)
            {

                // System.Console.WriteLine(number+" x "+minNum+" = "+number*minNum);
                System.Console.WriteLine($"{number} x {minNum} = {number * minNum}");

                // Increment or Decrement;
                minNum = minNum + 1;
                // minNum++;
                // minNum+=minNum;
            }
        }
        static void ForLoopPrintMultiplicationTable(int number)
        {

            //for(initialization;condition;increment/decrement)
            for (int minNum = 1, maxNum = 10; minNum <= maxNum; minNum++)
            {
                System.Console.WriteLine($"{number} x {minNum} = {number * minNum}");
            }

        }
        static void DoWhileLoopPrintMultiplicationTable(int number)
        {
            int maxNum = 10;
            int minNum = 1;

            do
            {
                
                System.Console.WriteLine($"{number} x {minNum} = {number * minNum}");
                minNum++;

            } while (minNum <= maxNum);
        }
    }
}
