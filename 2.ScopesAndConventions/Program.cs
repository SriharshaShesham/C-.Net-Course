// 1. Camel Case (starting small letter followed by Caps letter for all the words)
// 1. Pascal Case (Caps letter for all the words)


using System;

namespace _2.ScopesAndConventions
{
    //Class Name Pascal case
    class Program 
    {
        //Method Name Pascal case
        static void Main(string[] args)
        {
            //variable declaration Camel Case (starting small letter followed by Caps letter for all the words)
            int firstNumberToAdd = 3;
            int secondNumberToAdd = 4;
            const float Pi=3.14f;

            {
                int thirdNumberToAdd=6;

                {
                    int fourthNumberToAdd=7;
                }

                
            }

            Console.WriteLine(firstNumberToAdd);
            Console.WriteLine(secondNumberToAdd);
            Console.WriteLine(thirdNumberToAdd);
            Console.WriteLine(fourthNumberToAdd);
            

        }
    }
}
