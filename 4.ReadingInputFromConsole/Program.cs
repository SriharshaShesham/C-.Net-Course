using System;

namespace _4.ReadingInputFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AddLineBreaks();
            DisplayBasicUserInformation();
            AddLineBreaks();
        }

        static void DisplayBasicUserInformation()
        {
            // string firstName="Mukesh";
            // string lastName="Ambani";

            //variable declaration
            string firstName="";
            string lastName="";

            string userFullName="User full name is: "+firstName+" "+lastName;

            //variable initialization
            // firstName="Mukesh";
            // lastName="Ambani";
            System.Console.WriteLine("User Information Panel");
            System.Console.WriteLine("----------------------");
            
            System.Console.WriteLine("Enter First Name");
            System.Console.WriteLine(userFullName);   // <------------


            System.Console.WriteLine("Enter Last Name");
            lastName=Console.ReadLine();
            
            // DisplayUserFullName();


            AddLineBreaks();
            System.Console.WriteLine("Entered User information");
            System.Console.WriteLine(userFullName);
            // System.Console.WriteLine($"User full name is: {firstName} {lastName}");
        }


        

        static void AddLineBreaks()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}



// |--------------------------------------------------
                UserName

            --------------------
                Password