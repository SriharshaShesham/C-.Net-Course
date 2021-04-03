using System;

namespace _5._1._Conditions_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditions
            // ==
            // !=
            // >
            // <
            // >=
            // <=

            byte inputNumber1,inputNumber2;
            string userName1,userName2;

            System.Console.WriteLine("Number comparision");
            System.Console.WriteLine("----------------------");

            System.Console.WriteLine("Enter two numbers");
            inputNumber1=Convert.ToByte(Console.ReadLine());
            inputNumber2=Convert.ToByte(Console.ReadLine());

            

            if(inputNumber1>inputNumber2)
            {
                System.Console.WriteLine($"{inputNumber1} is greater than {inputNumber2}");
                //System.Console.WriteLine(inputNumber1+" is greater than "+inputNumber2);
            }
            //if(inputNumber1<inputNumber2)
            else
            {
                System.Console.WriteLine($"{inputNumber1} is less than {inputNumber2}");
            }

            
            if(inputNumber1>=inputNumber2)
                System.Console.WriteLine($"{inputNumber1} is greater than equal to {inputNumber2}");

            if(inputNumber1<=inputNumber2)
                System.Console.WriteLine($"{inputNumber1} is less than equal to {inputNumber2}");

            System.Console.WriteLine("String comparision");
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Enter two names");
            userName1=Console.ReadLine();
            userName2=Console.ReadLine();

            if(userName1==userName2)
                System.Console.WriteLine($"{userName1} is equal to {userName2}");
            else
                System.Console.WriteLine($"{userName1} is not equal to {userName2}");


            if(userName1=="")
            {
                System.Console.WriteLine("User Name is blank");
            }
            
            
        }
    }
}
