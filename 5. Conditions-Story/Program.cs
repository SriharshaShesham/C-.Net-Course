using System;

namespace _5._Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raju
            //Mantri
            //MantriKavlanaeVyakti


            //Cheppina pani cheyadam
            //Vishayanm telusukovadam
            //Salaha ivvadam

            string conditionOne="CheppinaPaniCheyadam";
            string conditionTwo="VishayamTelusukovadam";
            string conditionThree="SalahaIvvadam";

            //CheppinaPaniCheyadam. VishayamTelusukovadam. SalahaIvvadam

            string output="";

            Console.WriteLine("Raju: Velli Vallu yevaro telusukoni ra");
            output=Console.ReadLine();

            if(output=="CheppinaPaniCheyadam. VishayamTelusukovadam. SalahaIvvadam")
            {
                System.Console.WriteLine("Promoted as Minister");
            }

            if(output!="CheppinaPaniCheyadam. VishayamTelusukovadam. SalahaIvvadam")
            {
                System.Console.WriteLine("Not promoted as Minister");
            }
            
        }
    }
}
