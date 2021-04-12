using System;

namespace _7.SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {

            byte userChoice = 0;

            System.Console.WriteLine("1. Morning Greeting");
            System.Console.WriteLine("2. Afternoon Greeting");
            System.Console.WriteLine("3. Evening Greeting");
            System.Console.WriteLine("4. Night Greeting");

            System.Console.WriteLine("Select your option");
            userChoice = byte.Parse(Console.ReadLine());





            // ---------------------- Using switch ----------------------------

            
            switch (userChoice)
            {
                case 1:
                    {
                        System.Console.WriteLine("Good Morning Sir");
                        System.Console.WriteLine("The weather is 32 degree celcius");
                    }
                    break;

                case 2:
                    {
                        System.Console.WriteLine("Good Afternoon sir");
                        System.Console.WriteLine("Its your lunch time");
                    }
                    break;

                case 3:
                    {
                        System.Console.WriteLine("Good evening sir");
                        System.Console.WriteLine("Its time to leave for home");
                        System.Console.WriteLine("The traffic is moderate. The time to home is 1 hr");
                    }

                default:
                    {
                        System.Console.WriteLine("Sir! Its time for bed");
                        System.Console.WriteLine("Here is your night playlist");
                        System.Console.WriteLine("Good night sir");
                    }
                    break;
            }

            // ---------------------- End using switch ----------------------------

        }

        static void usingIfElse(byte userChoice)
        {
            // ---------------------- Using if else ----------------------------

            if (userChoice == 1)
            {
                System.Console.WriteLine("Good Morning Sir");
                System.Console.WriteLine("The weather is 32 degree celcius");
            }

            else if (userChoice == 2)
            {
                System.Console.WriteLine("Good Afternoon sir");
                System.Console.WriteLine("Its your lunch time");
            }

            else if (userChoice == 3)
            {
                System.Console.WriteLine("Good evening sir");
                System.Console.WriteLine("Its time to leave for home");
                System.Console.WriteLine("The traffic is moderate. The time to home is 1 hr");
            }

            else
            {
                System.Console.WriteLine("Sir! Its time for bed");
                System.Console.WriteLine("Here is your night playlist");
                System.Console.WriteLine("Good night sir");
            }


            // ---------------------- End of using if else ----------------------------
        }
    }
}
