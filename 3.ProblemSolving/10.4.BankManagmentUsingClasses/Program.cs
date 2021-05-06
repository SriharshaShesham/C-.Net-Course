using System;

namespace _10._4.BankManagmentUsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankObj=new Bank();

            bankObj.InitialBalance=3000;
            

            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            bankObj.Deposit(1000);
            

            bankObj.WIthdraw(100);
            

            bankObj.PrintStatement();
        }
    }
}
