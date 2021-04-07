using System;

namespace Recap1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAccountInformation();
        }
        static void LineBreaks()
        {
            Console.WriteLine();
        }
        static void UserAccountInformation()
        {
           Float minBalance=100.00,deposit=0.0,withdraw=0.0;
           //double accountNumber=123654789321;
           Float balance=0;
           int option=0; 
           //string withdrawamt,warning;
           option=Convert.ToInt16(Console.ReadLine()); 
           if(option==1)
           {
               deposit=float.Parse(Console.ReadLine());
               balance=minBalance+deposit;
           }
           else if(option==2)
           {
               withdraw=Float.Parse(Console.ReadLine());
               if(Withdraw<=minBalance)
               {
                   balance=minBalance-withdraw;
               }
               else
               {
                   //withdrawamt="No sufficient balance";
               }
           }
           else
           {
               //warning="Please Enter Valid Option";
           }
           LineBreaks();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("*                                  Welcome to XYZ Bank                                   *");
            Console.WriteLine("*________________________________________________________________________________________*");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("* Please Choose Your Banking Option                                                      *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("* 1) Deposit                                                                             *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("* 2) Withdraw                                                                            *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*"+balance+"                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("******************************************************************************************");
        }
    }
}
