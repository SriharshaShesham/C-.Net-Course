using System;

namespace ClassessAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            //This array has 3 items
            int[] arrayName = new int[3];
            
            //This Student array has 3 items
            Student[] students = new Student[3];
            

            // Student student=new Student();
            students[0]=new Student();
            
            arrayName[0]=1;

        

            students[0]=new Student();
            students[0].StudentID=1234;
            
            students[1]=new Student();
            students[1].StudentID=1234;

            students[2]=new Student();
            students[2].StudentID=1234;

            for (int counter = 0; counter < students.Length; counter++)
            {
                System.Console.WriteLine(students[counter].StudentID);
            }

            
            
        }
    }

    class Student
    {
        int _studentID;
        string _studentFirstName;
        string _studentLastName;
        char _gender;

        public int StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                if (value > 0)
                {
                    _studentID = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return _studentFirstName;
            }
            set
            {
                _studentFirstName = value;
            }
        }

    }

}
