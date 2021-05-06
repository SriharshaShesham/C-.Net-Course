using System;

namespace _10._4.BankManagmentUsingClasses
{

    class Bank
    {

        int _userBalance = 0;
        const int minimumBalance=1000;

        int[] _transactionType = new int[15]; //Deposit -> 1; Withdraw -> 2
        
        int[] _transactionAmount = new int[15]; //amount

        int _transactionCounter=0;

        public int InitialBalance
        {
            set
            {
                _userBalance = value;
             }
        }

        public void Deposit(int amount)
        {
            _userBalance+=amount;
            _transactionType[_transactionCounter]=1;
            _transactionAmount[_transactionCounter]=amount;
            _transactionCounter++;
            

        }

        public void WIthdraw(int amount)
        {
            if((_userBalance - minimumBalance) > amount)
            {
                _userBalance-=amount;


                _transactionType[_transactionCounter]=2;
                _transactionAmount[_transactionCounter]=amount;
                _transactionCounter++;
            }
        }

        public void PrintStatement()
        {
            
            string transactionType="";
            
                Console.WriteLine($"Transaction Type                Transaction Amount");
                Console.WriteLine($"-----------------               --------------------");

                for(int counter=0;counter<_transactionCounter;counter++)
                {

                    // System.Console.WriteLine(_transactionType[counter]);

                    if(_transactionType[counter]==1)
                        transactionType="Deposit";
                    else if(_transactionType[counter]==2)
                        transactionType="Withdraw";
                    Console.WriteLine($"{transactionType}                {_transactionAmount[counter]}");
                }


                Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine($"Current Balance                     {_userBalance}");



        }
    }
}
