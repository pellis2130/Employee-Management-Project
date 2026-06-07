/*******************************************************************
* Name: Princess Ellis
* Date: 06/07/2026
* Purpose: Main application class for Week 4 Employee Management
* Project. Demonstrates SQLite database CRUD operations.
*******************************************************************/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeDatabase database = new EmployeeDatabase();
        database.CreateDatabase();

        Console.WriteLine("===================================================");
        Console.WriteLine(" WEEK 4 PROJECT - EMPLOYEE MANAGEMENT SYSTEM");
        Console.WriteLine(" Created By: Princess Ellis");
        Console.WriteLine("===================================================");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Employee Management System!");
        Console.WriteLine("This Week 4 demo demonstrates SQLite database CRUD operations.");
        Console.WriteLine();

        Address address1 = new Address("101 Main Street", "Norfolk", "VA", "23501");
        Address address2 = new Address("202 Oak Avenue", "Virginia Beach", "VA", "23451");
        Address address3 = new Address("303 Pine Road", "Chesapeake", "VA", "23320");

        Employee employee1 = new SalariedEmployee(201, "Marcus", "Hill", "Sales Department", address1, 72000m);
        Employee employee2 = new HourlyEmployee(202, "Emily", "Carter", "IT Department", address2, 28.50m, 40m);
        Employee employee3 = new CommissionEmployee(203, "Jordan", "Smith", "Marketing Department", address3, 15000m, 0.10m);

        Console.WriteLine("CREATE: Adding employees to the database...");
        database.AddEmployee(employee1);
        database.AddEmployee(employee2);
        database.AddEmployee(employee3);
        Console.WriteLine("Employees added successfully.");
        Console.WriteLine();

        Console.WriteLine("READ: Displaying all employees from the database...");
        Console.WriteLine("------------------------------------------");
        database.DisplayAllEmployees();
        Console.WriteLine();

        Console.WriteLine("READ: Displaying only Hourly Employees...");
        Console.WriteLine("------------------------------------------");
        database.DisplayEmployeesByType("Hourly Employee");
        Console.WriteLine();

        Console.WriteLine("UPDATE: Updating Employee 202 department...");
        database.UpdateEmployeeDepartment(202, "Software Development Department");
        Console.WriteLine("Employee updated successfully.");
        Console.WriteLine();

        Console.WriteLine("READ: Displaying employees after update...");
        Console.WriteLine("------------------------------------------");
        database.DisplayAllEmployees();
        Console.WriteLine();

        Console.WriteLine("DELETE: Deleting Employee 203...");
        database.DeleteEmployee(203);
        Console.WriteLine("Employee deleted successfully.");
        Console.WriteLine();

        Console.WriteLine("READ: Displaying employees after delete...");
        Console.WriteLine("------------------------------------------");
        database.DisplayAllEmployees();

        Console.WriteLine();
        Console.WriteLine("End of Week 4 Project Demo.");
    }
}