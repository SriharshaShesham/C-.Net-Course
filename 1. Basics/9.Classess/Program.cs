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

            userObj.SetUserName("Krishna");
            System.Console.WriteLine(userObj.userName);

            // int age=GetUserAge();
            // System.Console.WriteLine($"User age is {age}");
        }

        
    }

    class UserClass
    {
        // int[] tempArray= new int[10];
        private string userName=""; 
        private int userAge=-1;

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string inputUserName)
        {
            if(inputUserName!="")
                userName=inputUserName;
        }

    }
}
