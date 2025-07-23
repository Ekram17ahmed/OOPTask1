using BLL.Departments;
using BLL.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Users
{
    public class Employee
    {
        public Project[] Projects { get; set; } = new Project[10];
        public Department department { get; set; } = new Department();

        public int Id;
        public string Name;
        public double Salary;

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
            foreach (var project in Projects)
            {
                if (project != null)
                    Console.WriteLine($"Project: {project.Name} (ID: {project.Id})");
            }


            if (department != null)
                Console.WriteLine($"Department: {department.Name} (ID: {department.Id})");
        }
    }
}
