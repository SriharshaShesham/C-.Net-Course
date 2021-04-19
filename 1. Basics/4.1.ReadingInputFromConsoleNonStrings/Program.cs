using System;

namespace _4._1.ReadingInputFromConsoleNonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declartion
            string userName;
            byte userAge;
            string userWeightAsString;
            int userWeight;
            float userHeight;
            char userInitial;

            //variable initialization
            //userName="";
            //userAge=0;
            //userHeight=5.11f;
            //userInitial='S';

            //Display Statements
            Console.WriteLine("Please enter user name");
            //userName is a string, Console.ReadLine() always a string
            //string == string
            userName=Console.ReadLine();
            // System.Console.WriteLine(userName.GetType());

            System.Console.WriteLine("Please enter user age");
            //userAge is int, Console.ReadLine() is always a string
            //int != string. So we need to convert the string to int
            userAge=Convert.ToByte(Console.ReadLine());
            // System.Console.WriteLine(userAge.GetType());


            System.Console.WriteLine("Please enter user weight");
            userWeightAsString=Console.ReadLine();
            userWeight=Convert.ToInt16(userWeightAsString);
            

            System.Console.WriteLine("Please enter user Height");
            userHeight= float.Parse(Console.ReadLine());

            
            System.Console.WriteLine("Entered Name is "+userName);
            System.Console.WriteLine("User Age is: "+userAge);
        }
    }
}




/*
User data to capture:
----------------------
FirstName
Lastname
UserInitial(character)
Age
Weight
Height
Address
Zipcode
PhoneNumber




*/