/*
Name: Princess Ellis
Date: May 17, 2026
Purpose: Week 1 Project demonstrating inheritance and composition
*/

using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee Management System";

            Console.WriteLine("===================================================");
            Console.WriteLine(" WEEK 1 PROJECT - EMPLOYEE MANAGEMENT SYSTEM");
            Console.WriteLine(" Created By: Princess Ellis");
            Console.WriteLine("===================================================\n");

            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("This application demonstrates inheritance and composition.\n");

            // Composition demonstration
            Office salesOffice = new Office("Sales Department");

            // Inheritance demonstration
            Manager manager1 = new Manager(
                201,
                "Marcus Hill",
                65000,
                salesOffice);

            Developer developer1 = new Developer(
                202,
                "Emily Carter",
                "C#",
                salesOffice);

            List<Employee> employees = new List<Employee>();

            employees.Add(manager1);
            employees.Add(developer1);

            Console.WriteLine("EMPLOYEE INFORMATION");
            Console.WriteLine("---------------------------------------------------\n");

            foreach (Employee employee in employees)
            {
                employee.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    /*
    Base class demonstrating inheritance
    */
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        // Composition demonstration
        public Office EmployeeOffice { get; set; }

        public Employee(int id, string name, Office office)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeOffice = office;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Department: {EmployeeOffice.OfficeName}");
        }
    }

    /*
    Child class demonstrating inheritance
    */
    class Manager : Employee
    {
        public double Salary { get; set; }

        public Manager(int id, string name,
            double salary, Office office)
            : base(id, name, office)
        {
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Position: Manager");
            Console.WriteLine($"Annual Salary: ${Salary}");
        }
    }

    /*
    Child class demonstrating inheritance
    */
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(int id, string name,
            string language, Office office)
            : base(id, name, office)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Position: Developer");
            Console.WriteLine($"Primary Language: {ProgrammingLanguage}");
        }
    }

    /*
    Class demonstrating composition
    */
    class Office
    {
        public string OfficeName { get; set; }

        public Office(string officeName)
        {
            OfficeName = officeName;
        }
    }
}