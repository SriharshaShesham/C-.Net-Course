using System;

namespace _5._2_Conditions_Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName="";
            string lastName="";

            System.Console.WriteLine("Enter user first name");
            firstName=Console.ReadLine();
            System.Console.WriteLine("Enter user last name");
            lastName=Console.ReadLine();
            
            
            if(CheckIfStringIsEmpty(firstName))//if(true/false)
                System.Console.WriteLine("Invalid first name");
            if(CheckIfStringIsEmpty(lastName))
                System.Console.WriteLine("Invalid last name");


        }
        
        
        // returnType FunctionName(parameterType parameterName)
        static bool CheckIfStringIsEmpty(string inputString)  
        {
            if(inputString=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
