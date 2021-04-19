using System;

namespace _8._2.StoppingTheLoop
{
    class Program
    {
        const int GenericUriParserOptions=3456;
        static void Main(string[] args)
        {
            byte userSelection;
            int inputOne,inputTwo;
            char userContinueChoice;
            
            Console.WriteLine("Addition and Multiplication of numbers");
            Console.WriteLine("--------------------------------------");

            do{
                System.Console.WriteLine("1. Add two numbers");
                System.Console.WriteLine("2. Multiply two numbers");
                userSelection=byte.Parse(Console.ReadLine());

                switch(userSelection)
                {
                    case 1:
                    {
                        inputOne=GetUserInput();
                        inputTwo=GetUserInput();
                        System.Console.WriteLine($"Sum of two numbers: {inputOne+inputTwo}");
                    }break;

                    case 2:
                    {
                        inputOne=GetUserInput();
                        inputTwo=GetUserInput();
                        System.Console.WriteLine($"Product of two numbers: {inputOne*inputTwo}");
                    }break;

                    default:
                    {
                        System.Console.WriteLine("Please enter a valid choice");
                    }
                }


                System.Console.WriteLine("Do you wish to continue (y/n)");
                userContinueChoice=Char.Parse(Console.ReadLine());


            }while(userContinueChoice=='y');


        }

        static int GetUserInput()
        {
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
