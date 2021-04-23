using System;

namespace _1._4._2.FindDuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1= new int[]{1,2,2,4,2,3,2,4,1,4,6};

            int[] outputArray= new int[array1.Length];

            int outputArrCounter=0;

            //sample output 1*5
            for(int counter=0;counter<array1.Length;counter++)
            {
                //counter 0
                for(int arr2Counter=0;arr2Counter<array1.Length;arr2Counter++)
                {
                    // arr2Counter=1
                    if(counter !=arr2Counter)
                    {
                        if(array1[counter] ==array1[arr2Counter])
                        {
                            if(!CheckIfValueExistsInArray(outputArray,array1[counter]))
                            {
                                outputArray[outputArrCounter]=array1[counter];
                                outputArrCounter++;
                            }
                        }
                    }
                    
                }
            }

            System.Console.WriteLine($"TOtal duplicates: {outputArrCounter}");
            for (int counter = 0; counter < outputArrCounter; counter++)
            {
                System.Console.WriteLine(outputArray[counter]);
            }
        }



        static bool CheckIfValueExistsInArray(int[] inArray,int valueToCheck)
        {
            for (int counter = 0; counter < inArray.Length; counter++)
            {
                if(inArray[counter]==valueToCheck)
                    return true;
            }

            return false;
        }
    }
}

