/*******************************************************************
* Name: Princess Ellis
* Date: 06/14/2026
* Purpose: Final Project main application class for the Employee
* Management System. Demonstrates a menu-driven console application
* using SQLite database CRUD operations.
*******************************************************************/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeDatabase database = new EmployeeDatabase();
        database.CreateDatabase();

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("===================================================");
            Console.WriteLine(" FINAL PROJECT - EMPLOYEE MANAGEMENT SYSTEM");
            Console.WriteLine(" Created By: Princess Ellis");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("Please select an option from the menu below.");
            Console.WriteLine();
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All Employees");
            Console.WriteLine("3. Display Employees By Type");
            Console.WriteLine("4. Update Employee Department");
            Console.WriteLine("5. Remove Employee");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    AddEmployee(database);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("ALL EMPLOYEES");
                    Console.WriteLine("------------------------------------------");
                    database.DisplayAllEmployees();
                    Pause();
                    break;

                case "3":
                    DisplayEmployeesByType(database);
                    break;

                case "4":
                    UpdateEmployee(database);
                    break;

                case "5":
                    RemoveEmployee(database);
                    break;

                case "6":
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Employee Management System!");
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid selection. Please try again.");
                    Pause();
                    break;
            }
        }
    }

    public static void AddEmployee(EmployeeDatabase database)
    {
        Console.Clear();
        Console.WriteLine("ADD EMPLOYEE");
        Console.WriteLine("------------------------------------------");

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine() ?? "";

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine() ?? "";

        Console.Write("Enter Department: ");
        string department = Console.ReadLine() ?? "";

        Console.Write("Enter Street Address: ");
        string street = Console.ReadLine() ?? "";

        Console.Write("Enter City: ");
        string city = Console.ReadLine() ?? "";

        Console.Write("Enter State: ");
        string state = Console.ReadLine() ?? "";

        Console.Write("Enter Zip Code: ");
        string zipCode = Console.ReadLine() ?? "";

        Address address = new Address(street, city, state, zipCode);

        Console.WriteLine();
        Console.WriteLine("Select Employee Type:");
        Console.WriteLine("1. Salaried Employee");
        Console.WriteLine("2. Hourly Employee");
        Console.WriteLine("3. Commission Employee");
        Console.Write("Enter your choice: ");

        string typeChoice = Console.ReadLine() ?? "";
        Employee employee;

        if (typeChoice == "1")
        {
            Console.Write("Enter Annual Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine() ?? "0");

            employee = new SalariedEmployee(id, firstName, lastName, department, address, salary);
        }
        else if (typeChoice == "2")
        {
            Console.Write("Enter Hourly Rate: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Hours Worked: ");
            decimal hoursWorked = decimal.Parse(Console.ReadLine() ?? "0");

            employee = new HourlyEmployee(id, firstName, lastName, department, address, hourlyRate, hoursWorked);
        }
        else if (typeChoice == "3")
        {
            Console.Write("Enter Base Salary: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Commission Rate Example 0.10: ");
            decimal commissionRate = decimal.Parse(Console.ReadLine() ?? "0");

            employee = new CommissionEmployee(id, firstName, lastName, department, address, baseSalary, commissionRate);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid employee type. Employee was not added.");
            Pause();
            return;
        }

        database.AddEmployee(employee);

        Console.WriteLine();
        Console.WriteLine("Employee added successfully.");
        Pause();
    }

    public static void DisplayEmployeesByType(EmployeeDatabase database)
    {
        Console.Clear();
        Console.WriteLine("DISPLAY EMPLOYEES BY TYPE");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1. Salaried Employee");
        Console.WriteLine("2. Hourly Employee");
        Console.WriteLine("3. Commission Employee");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine() ?? "";
        string employeeType = "";

        if (choice == "1")
        {
            employeeType = "Salaried Employee";
        }
        else if (choice == "2")
        {
            employeeType = "Hourly Employee";
        }
        else if (choice == "3")
        {
            employeeType = "Commission Employee";
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid employee type.");
            Pause();
            return;
        }

        Console.WriteLine();
        Console.WriteLine(employeeType.ToUpper() + "S");
        Console.WriteLine("------------------------------------------");

        database.DisplayEmployeesByType(employeeType);

        Pause();
    }

    public static void UpdateEmployee(EmployeeDatabase database)
    {
        Console.Clear();
        Console.WriteLine("UPDATE EMPLOYEE DEPARTMENT");
        Console.WriteLine("------------------------------------------");

        Console.Write("Enter Employee ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter New Department: ");
        string newDepartment = Console.ReadLine() ?? "";

        database.UpdateEmployeeDepartment(id, newDepartment);

        Console.WriteLine();
        Console.WriteLine("Employee updated successfully.");
        Pause();
    }

    public static void RemoveEmployee(EmployeeDatabase database)
    {
        Console.Clear();
        Console.WriteLine("REMOVE EMPLOYEE");
        Console.WriteLine("------------------------------------------");

        Console.Write("Enter Employee ID to remove: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        database.DeleteEmployee(id);

        Console.WriteLine();
        Console.WriteLine("Employee removed successfully.");
        Pause();
    }

    public static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}