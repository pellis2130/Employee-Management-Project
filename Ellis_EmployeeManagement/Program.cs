/*******************************************************************
* Name: Princess Ellis
* Date: 05/24/2026
* Purpose: Main application class for Week 2 Employee Management
* Project. Demonstrates interface creation and polymorphism.
*******************************************************************/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===================================================");
        Console.WriteLine(" WEEK 2 PROJECT - EMPLOYEE MANAGEMENT SYSTEM");
        Console.WriteLine(" Created By: Princess Ellis");
        Console.WriteLine("===================================================");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Employee Management System!");
        Console.WriteLine("This Week 2 demo demonstrates an interface and polymorphism.");
        Console.WriteLine();

        Address address1 = new Address(
            "101 Main Street",
            "Norfolk",
            "VA",
            "23501");

        Address address2 = new Address(
            "202 Oak Avenue",
            "Virginia Beach",
            "VA",
            "23451");

        Address address3 = new Address(
            "303 Pine Road",
            "Chesapeake",
            "VA",
            "23320");

        Employee salariedEmployee = new SalariedEmployee(
            201,
            "Marcus",
            "Hill",
            "Sales Department",
            address1,
            72000m);

        Employee hourlyEmployee = new HourlyEmployee(
            202,
            "Emily",
            "Carter",
            "IT Department",
            address2,
            28.50m,
            40m);

        Employee commissionEmployee = new CommissionEmployee(
            203,
            "Jordan",
            "Smith",
            "Marketing Department",
            address3,
            15000m,
            0.10m);

        // Polymorphism demonstration:
        // A List<Employee> can store different derived employee types.
        List<Employee> employees = new List<Employee>
        {
            salariedEmployee,
            hourlyEmployee,
            commissionEmployee
        };

        Console.WriteLine("EMPLOYEE INFORMATION USING POLYMORPHISM");
        Console.WriteLine("---------------------------------------------------");

        foreach (Employee employee in employees)
        {
            PrintEmployee(employee);
            Console.WriteLine("---------------------------------------------------");
        }

        Console.WriteLine();
        Console.WriteLine("INTERFACE DEMONSTRATION");
        Console.WriteLine("---------------------------------------------------");

        // Interface demonstration:
        // IPrintable can reference any class that implements it.
        IPrintable printableEmployee = salariedEmployee;
        Console.WriteLine(printableEmployee.GetDisplayInfo());

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("End of Week 2 Project Demo.");
    }

    private static void PrintEmployee(Employee employee)
    {
        Console.WriteLine(employee.GetDisplayInfo());
    }
}