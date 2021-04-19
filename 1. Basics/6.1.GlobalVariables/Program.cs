using System;

namespace _6._1.GlobalVariables
{
    class Program
    {
        static int userStartingBalance=1000;
        static const int minimumBalance=100;
        
        static void Main(string[] args)
        {
            
            Withdraw(100);
            System.Console.WriteLine(userStartingBalance);
        }

        static void Withdraw(int amount)
        {
            userStartingBalance+=amount;     // userStartingBalance = userStartingBalance + amount;
               
        }

        
    }
}
