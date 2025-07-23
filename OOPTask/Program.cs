using BLL.Departments;
using BLL.Projects;
using BLL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - Get All Employees");
                Console.WriteLine("3 - Update Employee");
                Console.WriteLine("4 - Get Employee By ID");
                Console.WriteLine("0 - Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        EmployeeManager.AddEmployee();
                        break;
                    case "2":
                        EmployeeManager.GetAllEmployees();
                        break;
                    case "3":
                        EmployeeManager.UpdateEmployee();
                        break;
                    case "4":
                        EmployeeManager.GetEmployeeById();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        
    }
}
