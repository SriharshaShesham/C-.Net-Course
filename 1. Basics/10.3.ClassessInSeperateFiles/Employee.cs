using System;

namespace _10._3.ClassessInSeperateFiles
{
    class Employee
    {
        private int _employeeID;
        public int EmployeeID { 
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID=value;
            }
        }
        public string EmployeeName { get; set; }

        public void UpdateEmployeeID(int newID)
        {
            
        }
    }
}