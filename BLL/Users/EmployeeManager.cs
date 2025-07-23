using BLL.Projects;
using BLL.Departments;
using BLL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Users
{
    public class EmployeeManager
    {
        static Employee[] employees = new Employee[10];
        static int count = 0;
        public static void AddEmployee()
        {
            if (count >= employees.Length)
            {
                Console.WriteLine("Employee list is full.");
                return;
            }

            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            int projectCount = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Assign to:");
                Console.WriteLine("1 - Add Project");
                Console.WriteLine("2 - Add Department");
                Console.WriteLine("0 - Done");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        if (projectCount >= emp.Projects.Length)
                        {
                            Console.WriteLine("Maximum number of projects reached.");
                            break;
                        }

                        Project project = new Project();
                        Console.Write("Enter Project ID: ");
                        project.Id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Project Name: ");
                        project.Name = Console.ReadLine();

                        emp.Projects[projectCount++] = project;
                        break;

                    case "2":
                        Console.Write("Enter Department ID: ");
                        emp.department.Id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Department Name: ");
                        emp.department.Name = Console.ReadLine();
                        break;

                    case "0":
                        goto Done; // Exit the while loop
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

        Done:
            Console.Clear();
            employees[count++] = emp;
            Console.WriteLine("Employee added successfully.");
        }


        public static void GetAllEmployees()
        {
            Console.WriteLine("\nAll Employees:");
            for (int i = 0; i < count; i++)
            {
                employees[i].Display();
            }
        }

        public static void UpdateEmployee()
        {
            Console.Write("Enter ID of employee to update: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    Console.Write("Enter new name: ");
                    employees[i].Name = Console.ReadLine();

                    Console.Write("Enter new salary: ");
                    employees[i].Salary = double.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Employee updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public static void GetEmployeeById()
        {
            Console.Write("Enter ID to search: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i].Display();
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

    }
}
