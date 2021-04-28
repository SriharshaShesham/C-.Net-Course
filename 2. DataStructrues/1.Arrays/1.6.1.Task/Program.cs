using System;

namespace MultidimentionalArray
{
    class Program
    {

        static string[,] employeTable = new string[2, 3] 
        {
            { "User1", "1234", "User" },
            { "User2", "4321", "Manager" }
        };
        static int rows=employeTable.GetLength(0);
        static int cols=employeTable.GetLength(1);

        static int userIndex=-1;
        static string name = "", password = "";
        static string[,] userDetails = new string[2, 5] { { "Nil", "Nil", "Nil", "Nil", "Nil" }, { "Nil", "Nil", "Nil", "Nil", "Nil" } };
        //static int loggedInUserIndex=-1;
        //static string loggedInUserRole="";
        static int row = 0, col = 0;
        static void Main(string[] args)
        {

            DisplayProgramTitle();
            LoginForm();

        }

        static void DisplayProgramTitle()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       User Login Verification program with Multidimentional Arrays");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

        }


        static void LoginForm()
        {

            Console.WriteLine("Login Form");
            Console.WriteLine();
            Console.Write("1.UserName : ");
            name = Console.ReadLine();
            Console.Write("2.Password : ");
            password = Console.ReadLine();
            Console.WriteLine();

            userIndex=ReturnUserIndexIfFound(name,password);
            userRole=GetUserRoleByIndex(userIndex);
            
            


        }

        static int ReturnUserIndexIfFound(string username,string psw)
        {
            for (int counter = 0; counter < rows; counter++)
            {
                if ((name == employeTable[counter,0]) && (password == employeTable[counter,1]))
                {

                    return counter;
                }

                
            }
            return -1;
        }
        

        static string GetUserRoleByIndex(int userIndex)
        {
            return employeTable[userIndex,2];
        }

        static void UserLogin()
        {

            string userInput = " ";
            Console.WriteLine("        User Login");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("Enter User Details");

            for (int row = 0; row < 2; row++)
            {

                for (int col = 0; col < 5; col++)
                {
                    userInput = Console.ReadLine();
                    userDetails[row, col] = userInput;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Now its managers turn");

            ManagerLogin();

        }

        static void ManagerLogin()
        {
            int option = 0;
            char continueOption = ' ';
            Console.WriteLine("      Hello Manager");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Diplay User Details  2. Check User");
                Console.WriteLine();
                Console.Write("Option : ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (option)
                {
                    case 1:
                        {
                            UserDetailsDisplay();
                        }
                        break;

                    case 2:
                        {
                            SearchUser();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Enter Valid Option");
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Mr.Manager do you want to continue your search");
                continueOption = char.Parse(Console.ReadLine());
            } while (continueOption == 'y');
            Console.WriteLine();
        }

        static void UserDetailsDisplay()
        {
            Console.WriteLine("S.No FirstName LastName  Gender E-Mail Id");
            Console.WriteLine("---- --------- --------  ------ ---------");
            for (row = 0; row < 2; row++)
            {
                for (col = 0; col < 5; col++)
                {
                    Console.Write($"{userDetails[row, col]} \t");
                }
                Console.WriteLine();
            }
        }

        static void SearchUser()
        {
            string search;
            int rowDetails = 0;
            Console.WriteLine("Please enter the keyword you want to search");
            search = Console.ReadLine();
            Console.WriteLine();
            for (row = 0; row < 2; row++)
            {
                for (col = 0; col < 5; col++)
                {
                    if ((userDetails[row, 1]) == search || (userDetails[row, 2]) == search || (userDetails[row, 3]) == search || (userDetails[row, 4]) == search)
                    {
                        rowDetails = row;
                    }
                }
            }
            Console.WriteLine("S.No FirstName   LastName    Gender  E-Mail Id");
            Console.WriteLine("---- ---------   --------    ------  ---------");

            row = rowDetails;
            for (col = 0; col < 5; col++)
            {
                Console.Write($"{userDetails[row, col]}\t");

            }
            Console.WriteLine();
        }
    }
}
