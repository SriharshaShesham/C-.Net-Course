using System;

namespace _10._2.StudentsInformationCollection
{
    class Students
    {
        private int counter = 0;


        private int studentsSize;
        
        public Student[] students { get; set; }

        public Students()
        {
            Console.WriteLine("Enter the Number Of Students");
            studentsSize = int.Parse(Console.ReadLine());
            students = new Student[studentsSize];
        }
        public void GetUserDetails()
        {


            for (counter = 0; counter < studentsSize; counter++)
            {
                students[counter]=new Student();
                
                students[counter].StudentID = " " + (counter + 1);
                
                Console.WriteLine($"Enter the first Name of the Student {counter + 1} ");
                string firstname = "TempF"+counter;
                
                students[counter].FirstName = firstname;
                
                Console.WriteLine($"Enter the Last  Name of the Student {counter + 1} ");
                string lastname = "TempF"+counter;
                students[counter].LastName = lastname;
                //
                Console.WriteLine($"Enter the Gender   of the Student {counter + 1} ");
                string gender = "Male";
                students[counter].Gender = gender;
                //
                
            }
        }

        public void PrintingEmployeeDetails()
        {




            for (counter = 0; counter < studentsSize; counter++)
            {

                // if (students[counter].Marks > 60)
                {
                    Console.WriteLine("Detail of Students whose marks are greater than 60");
                    Console.WriteLine($"StudentID={students[counter].StudentID}");
                    Console.WriteLine($" Student {counter + 1} Full Name :- {students[counter].FirstName + students[counter].LastName}");
                    Console.WriteLine($" Student Gender = {students[counter].Gender}");
                    Console.WriteLine($" Marks of the student = {students[counter].Marks}");

                }
            }

            Console.ReadLine();

        }
    }
}