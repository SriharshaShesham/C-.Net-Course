using System;

namespace _3.WritingOutputToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();

            // Step 1: Display greeting message
            GreetingMessage();

            //Step 2: User inserts the card and enters the pin. Validation is complete
            System.Console.WriteLine("User successfully validated");
            System.Console.WriteLine();

            //Step 3: Display User information
            DisplayBasicUserInfo();
            //UserID = 1234.
            //Hello Mukesh(1234)

            Console.WriteLine();
            Console.WriteLine();
        }

        static void DisplayBasicUserInfo()
        {
            string userFirstName="Mukesh";
            string userLastName="Ambani";
            
            System.Console.WriteLine("Hello "+userFirstName+" "+userLastName);
        }

        static void GreetingMessage()
        {
            
            Console.WriteLine("Welcome to ICICI Bank");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("Please insert your card");
            
        }
    }
}
