using System;

namespace _10.GettersAndSetters
{
    class Program
    {
        // int[] tempArray= new int[10];
       
        private static void Main(string[] args)
        {

            // int[] tempArray= new int[10];

            //TO access any class outsite of this class create an object.
            UserClass userObj=new UserClass();

            userObj.UserName="Krishna";
            System.Console.WriteLine(userObj.UserName);


            // Old way
            UserClass_Old userObjOld=new UserClass_Old();
            userObjOld.SetUserName("Krishna");
            System.Console.WriteLine(userObjOld.GetUserName());
            
        }

        
    }

    class UserClass_Old
    {
        // int[] tempArray= new int[10];
        private string userName=""; 
        private int userAge=-1;

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string value)
        {
            if(value!="")
                userName=value;
        }

    }

    class UserClass
    {
        // int[] tempArray= new int[10];

        // Add _ to private variable and make the public variable to Pascal case


        private string _userName="Rama";

        // If you don't need any validation but just need to initialize a value
        // public string UserName { get; set;}


        public string UserName 
        {
             get{
                //  ******Rama*********
                 return $"******{_userName}******";
             } 
             set
             {
                 if(value !="")
                    _userName=value;
             }
        }

    }
}


