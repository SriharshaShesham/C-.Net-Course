using System;

namespace _3._1.ConsoleDisplayApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserts two line brakes
            InsertLineBreaks();
            
            // Facebook
                //Displays greeting message for facebook
                FBGreeting();
                LoginPage();
            //End of Facebook calls

            InsertLineBreaks();
            TwitterGreeting();
            LoginPage();


            InsertLineBreaks();
        }

        static void InsertLineBreaks()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
        }



        static void FBGreeting()
        {
            System.Console.WriteLine("Facebook");
            System.Console.WriteLine("---------");
            System.Console.WriteLine();
            System.Console.WriteLine("Connect with friends and the world around you on Facebook.");
        }

        static void TwitterGreeting()
        {
            System.Console.WriteLine("Twitter Icon");
            System.Console.WriteLine("------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Log in to Twitter");
        }

        static void LoginPage()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("|        Enter your Phone or Email        |");
            System.Console.WriteLine("|          Enter your password            |");
            System.Console.WriteLine("|              Login Button               |");
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine();
        }
    }
}


/*

//Implement Facebook login similar to below

-------------------------------------------------------------
|
|               -------------------------------------
|               |   Enter your Phone number         |
|                ------------------------------------
|
-------------------------------------------------------------



*/