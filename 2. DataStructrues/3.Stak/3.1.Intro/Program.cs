using System;
using System.Collections.Generic;

namespace _3._1.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numStack=new Stack<int>();
            //Add
            //Remove
            //Clear
            //Contains

            numStack.Push(1);
            numStack.Push(2);
            numStack.Push(3);
            numStack.Push(4);
            numStack.Push(5);
            numStack.Push(6);

            PrintTheStack(numStack);

            System.Console.WriteLine("Number being Popped is "+numStack.Pop());

            PrintTheStack(numStack);

            System.Console.WriteLine($"Contains: {numStack.Contains(5)}");

            PrintTheStack(numStack);

            System.Console.WriteLine("Peak: "+numStack.Peek());;

            System.Console.WriteLine("Count: "+numStack.Count);;

            numStack.Clear();


            
            PrintTheStack(numStack);
            
            // System.Console.WriteLine("Peak: "+numStack.Peek());;


            string inputStr;

            System.Console.WriteLine("Enter a string");
            inputStr=Console.ReadLine();

            Stack<char> inStack = new Stack<char>();
            
            
            foreach(char inChar in inputStr) //  [a,b,c,d,e] -> Collection of Chars -> 
                inStack.Push(inChar);//Adding

            foreach(char inChar in inputStr)
                System.Console.WriteLine(inStack.Pop());

            // string name="Rama";
            // for(int Count=0;Count<name.Length;Count++)
            // {
            //     System.Console.WriteLine(name[Count]);
            // }



        }

        static void PrintTheStack(Stack<int> stackToPrint)
        {
            System.Console.WriteLine("Printing");
            foreach(int num in stackToPrint)
                System.Console.WriteLine(num);
        }
    }
}
