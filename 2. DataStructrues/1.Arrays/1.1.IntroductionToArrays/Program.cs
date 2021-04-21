using System;

namespace _1.Arrays
{
    class Program
    {
        static int counter=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction to Arrays");
            Console.WriteLine("-----------------------");

            // int number=100;
            int[] numbers=new int[5];
            // int[] knownNumbers=new int[]{1,2,3,4,5};

            // double floatingNumber=100.1;
            // char alphabet='c';
            // byte singleByteNubmer=1;

            System.Console.WriteLine($"Array Length: {numbers.Length}");

          
            for(counter=0;counter<numbers.Length;counter++)
            {
                System.Console.WriteLine($"Enter the number at {counter} index: ");
                numbers[counter]=int.Parse(Console.ReadLine());
            }

            

            for(counter=0;counter<numbers.Length;counter++)
            {
                System.Console.WriteLine($"The number at {counter} index: is {numbers[counter]}");
            }

            System.Console.WriteLine(numbers[3]);

        }

        

        static int Sum(int[] numbers)
        {
            
        }
    }
}
