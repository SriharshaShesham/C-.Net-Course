using System;

namespace _10._4.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company=new Company(5,1,"");
            Company companySecondObj=new Company(5);
            Company companyThirdObj=new Company();

            
        }
    }

    class Company
    {
        private Employee[] employees;
        int id;
        string userName;

        public Company()
        {
            id=0;
            userName="";
        }
        public Company(int Qty)
        {
            employees=new Employee[Qty];
            id=0;
            userName="";
        }

        public Company(int Qty, int id, string userName)
        {
            employees=new Employee[Qty];
            this.id=id;
            this.userName=userName;
        }

    }
}
