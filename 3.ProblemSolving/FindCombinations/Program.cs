using System;

namespace FindCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inpArray= new int[]{1,2,3,4};

            int inpNumber=6;
            
            int combinations=0;

            for(int counter=0;counter<inpArray.Length;counter++)
            {
                if(inpArray[counter]==inpNumber)
                {
                    combinations++;
                }
                else if(inpArray[counter]<inpNumber)
                {
                    for(int counterTwo=0;counterTwo<inpArray.Length;counterTwo++)
                    {
                        if(inpArray[counter]+inpArray[counterTwo]==inpNumber)
                        {
                            System.Console.WriteLine("{"+inpArray[counter]+", "+inpArray[counterTwo]+"}");
                            combinations++;
                        }
                    }  
                }
                
                 
            }

            System.Console.WriteLine("Combinations: "+combinations);

        }

        

    }
}
