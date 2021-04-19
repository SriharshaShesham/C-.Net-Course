using System;

namespace _6._2.FunctionsDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            
           number= setNumberValue(10);
           number= setNumberValuePlus10(60);
        }

        static int setNumberValue(int inputNumber) //inputNumber=10
        {
            return inputNumber;
        }

        static int setNumberValuePlus10(int inputNumber) //inputNumber=10
        {
            inputNumber=setNumberValue(10);
            inputNumber+=10;

            return inputNumber;
        }
    }
}
