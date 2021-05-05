using System;

namespace _10._2.StudentsInformationCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student data access Through three classes");
            Console.WriteLine("-----------------------------------------");
            Students admin = new Students();
            
            admin.GetUserDetails();
            admin.PrintingEmployeeDetails();
        }
    }

    

    
}
