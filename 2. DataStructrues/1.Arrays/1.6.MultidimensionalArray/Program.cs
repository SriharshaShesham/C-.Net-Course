using System;

namespace _1._6.MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Dimensional array");
            Console.WriteLine("------------------------");

            int[] array = new int[6];
            string[,] library=new string[4,3]; //4 members 3 columns[ID, BookName, Author]

            for(int book=0;book<4;book++)
            {
                for(int col=0;col<3;col++)                
                {
                    switch(col)
                    {
                        case 0:{
                            
                            library[book,0]=""+book;
                        }break;

                        case 1:
                        {
                            System.Console.WriteLine("Enter the book name:");
                            library[book,col]=Console.ReadLine();
                        }break;
                        
                        case 2:
                        {
                            System.Console.WriteLine("Enter the author name:");
                            library[book,col]=Console.ReadLine();
                        }break;
                    }
                }
            }

            System.Console.WriteLine("Books in Library");
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine();
            System.Console.WriteLine("ID    Book Name       Author");
            System.Console.WriteLine("---   ---------       ------");
            for (int book = 0; book < 4; book++)
            {
                for (int col = 0; col < 3; col++)
                {
                    System.Console.Write(library[book,col]);
                    if(col==0)
                    {
                        System.Console.Write("\t");
                    }
                    System.Console.Write("\t\t");
                    
                }
                System.Console.WriteLine();
            }

        }
    }
}
