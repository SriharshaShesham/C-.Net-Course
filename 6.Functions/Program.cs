using System;

namespace _6.Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            double userAc2432=2300;
            double userAc4532=300;
            double userAc1264=150;
            
            int minimumBalance=100;

            transactionHeader(1);
            userAc2432=Accountant(userAc2432,minimumBalance);
            PrintUserBalance(userAc2432);

            transactionHeader(2);
            userAc1264=Accountant(userAc1264,minimumBalance);
            PrintUserBalance(userAc1264);

            transactionHeader(3);
            userAc4532=Accountant(userAc4532,minimumBalance);
            PrintUserBalance(userAc4532);
        }

        static void transactionHeader(byte number)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine($"Transaction for User {number}");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine();
        }

        static double Accountant(double userAccountVariable, int minBalance)
        {
            System.Console.WriteLine("Welcome to our bank");
            System.Console.WriteLine("What would you like to do today");

            System.Console.WriteLine("1. Deposit ");
            System.Console.WriteLine("2. Withdrawl ");

            System.Console.WriteLine();
            System.Console.WriteLine("Please select your option");

            byte selectedOption= byte.Parse(Console.ReadLine());

            System.Console.WriteLine("Please enter the amount you want to Deposit/Withdraw");
            double amount=double.Parse(Console.ReadLine());

            double currentBalance;
            if(selectedOption==1)
            {
                currentBalance=Deposit(userAccountVariable,amount);
            }
            else
            {
                if(userAccountVariable-amount > minBalance)
                {
                    currentBalance= Withdraw(userAccountVariable,amount);
                }
                else
                {
                    System.Console.WriteLine($"Error: Insufficient funds available (Minimum balance is: {minBalance}");
                    currentBalance=userAccountVariable;
                }
            }

            return currentBalance;
        }

        static double Deposit(double userAccountVariable, double amount)
        {
            return userAccountVariable+amount;
        }

        static double Withdraw(double userAccountVariable, double amount)
        {
            
                return userAccountVariable-amount;
            
        }

        static void PrintUserBalance(double userAccountVariable)
        {
            System.Console.WriteLine($"User current statement balance : {userAccountVariable}");
        }

    }
}
