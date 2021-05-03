using System;

namespace _9.Classess
{
    class Program
    {
        // int[] tempArray= new int[10];
       
        private static void Main(string[] args)
        {

            // int[] tempArray= new int[10];

            //TO access user class create an object.
            UserClass userObj=new UserClass();
            userObj.userName="Test";

            // int age=GetUserAge();
            // System.Console.WriteLine($"User age is {age}");
        }

        
    }

    class UserClass
    {
        public string userName=""; 
        public int userAge=-1;

    }
}
