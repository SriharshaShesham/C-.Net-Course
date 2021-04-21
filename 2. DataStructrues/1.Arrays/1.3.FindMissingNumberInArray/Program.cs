using System;

namespace _1._3.FindMissingNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItemsInArray=0;
            int maxNumber=0;
            int[] inputArray;
            int missingNumber;
            PrintToConsole("Find missing number in array");
            PrintToConsole("------------------------------");

            numberOfItemsInArray=GetNumberOfItemsInArray();
            maxNumber=GetMaximumNumberThatGoesIntoArray();
            
            inputArray=new int[numberOfItemsInArray];

            inputArray=GetArrayValuesFromUser(numberOfItemsInArray,maxNumber);
            
            missingNumber=FindMissingNumber(inputArray);

            if(missingNumber !=-1)
            {
                PrintToConsole($"Missing number is {missingNumber}");
            }
            else
            {
                PrintToConsole("There are no missing numbers");
            }

        }

        static int FindMissingNumber(int[] inputArray)
        {
            int missingNumber=-1;
            for (int count = 1; count < inputArray.Length; count++)
            {
                if(inputArray[count]-inputArray[count-1]!=1)
                {
                    missingNumber=inputArray[count] -1;
                }
            }

            return missingNumber;
        }

        static int GetNumberOfItemsInArray()
        {
            PrintToConsole("Enter number of items you want to enter");
            return int.Parse(Console.ReadLine());
        }

        static int GetMaximumNumberThatGoesIntoArray()
        {
            PrintToConsole("Enter the maximum number that you would enter into the array");
            return int.Parse(Console.ReadLine());
        }


        static int[] GetArrayValuesFromUser(int arraySize,int maxNumber)
        {
            int[] outputArray=new int[arraySize];
            PrintToConsole($"Enter the values you want to put into the array (Note: no duplicates, only in ascending order and the maximum number allowed is {maxNumber})");
            
            
            for (int count = 0,temp; count < arraySize; count++)
            {
                temp=int.Parse(Console.ReadLine());
                if(temp>maxNumber)
                {
                    PrintToConsole($"Invalid entry. Please enter a number which is less than or equals {maxNumber}");
                    temp=int.Parse(Console.ReadLine());
                }
                outputArray[count]=temp;
            }

            return outputArray;
        }


        static int PrintToConsole(string messageToPrint)
        {
            System.Console.WriteLine(messageToPrint);
            return 1;
        }
    }
}
