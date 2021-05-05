using System;

namespace _10._3.ClassessInSeperateFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeID=123;
            emp.EmployeeName="Rama";
            emp.UpdateEmployeeID(345);
        }
    }
}
