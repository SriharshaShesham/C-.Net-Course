using System;

namespace _1._6.Task
{
    class Program
    {
        static string[] inputArray = new string[15];
        static void Main(string[] args)
        {
            int arraySize1 = 0;
            arraySize1=1;
            arraySize1 = GetArraySizeFromUser();
            //string[] inputArray = new string[15];
            //string[] outputArray=new string[arraySize];
            inputArray = GetArrayElementsFromUser( arraySize1);
            AddUsersInArray( arraySize1);
        }
        static int GetArraySizeFromUser()
        {
            int arraySize1 = 0;
            Console.WriteLine("Enter No.of Users");
            arraySize1 = Convert.ToInt16(Console.ReadLine());
            return arraySize1;
        }
        static string[] GetArrayElementsFromUser( int arraySize1)
        {
            Console.WriteLine("Enter Names of Users");
            for (int counter = 0; counter < arraySize1; counter++)
            {
                inputArray[counter] = Console.ReadLine();
            }
            return inputArray;
        }
        static void AddUsersInArray( int arraySize1)
        {
            string dup = "";
            string dup1 = "";
            char dummy = ' ';
            char dummy1 = ' ';
            int duplicate = 0;
            int duplicate1 = 0;
            string temp = "";
            int addNumOfUsers = 0;
            Console.WriteLine("Enter No.Of Users You Want to Add");
            addNumOfUsers = Convert.ToInt16(Console.ReadLine());
            //string[] outputArray = new string[15];
            /*for (int counter = 0; counter < arraySize1; counter++)
            {
                outputAr[counter] = inputArray[counter];
            }*/

            string name="Rama";
            dup=name+" Sitha";
            Console.WriteLine(name);

            // array["Rama","Sitha","Hanuma"]
            // R,S,H
            // temp=array[rowCounter];
            // array[rowCounter]

            Console.WriteLine("Enter name of User you want to Add");
            for (int counter = arraySize1; counter < arraySize1+addNumOfUsers ; counter++)
            {
                inputArray[counter] = Console.ReadLine();
            }
            for (int rowsCounter = 0; rowsCounter <  arraySize1 + addNumOfUsers; rowsCounter++)
            {
                for (int colCounter = rowsCounter; colCounter <  arraySize1 + addNumOfUsers; colCounter++)
                {
                    dup = inputArray[rowsCounter];
                    dup1 = inputArray[colCounter];
                    dummy = Char.Parse(dup.Substring(0, 1));
                    dummy1 =Char.Parse( dup1.Substring(0, 1));
                    //dummy=inputArray[counter][0];
                    //dummy1=inputArray[colCounter][0];
                    Console.WriteLine(dummy);
                    //Console.WriteLine(dummy1);
                    duplicate = (int)dummy;
                    duplicate1 =(int)dummy1;
                    //Console.WriteLine(duplicate);
                    //Console.WriteLine(duplicate1);

                    if (duplicate > duplicate1)
                    {
                        temp = dup;
                        inputArray[rowsCounter] = dup1;
                        inputArray[colCounter] = temp;
                    }
                }
            }
            for (int counter = 0; counter < arraySize1+addNumOfUsers; counter++)
            {
                Console.WriteLine(inputArray[counter]);
            }

            Console.ReadLine();

        }
    }
}
