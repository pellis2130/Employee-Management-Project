/*******************************************************************
* Name: Princess Ellis
* Date: 06/07/2026
* Purpose: Handles SQLite database creation and CRUD operations
* for the Employee Management System.
*******************************************************************/

using System;
using Microsoft.Data.Sqlite;

public class EmployeeDatabase
{
    private string connectionString = "Data Source=EmployeeManagement.db";

    public void CreateDatabase()
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string tableCommand =
        @"CREATE TABLE IF NOT EXISTS Employees (
            EmployeeId INTEGER PRIMARY KEY,
            FirstName TEXT NOT NULL,
            LastName TEXT NOT NULL,
            Department TEXT NOT NULL,
            EmployeeType TEXT NOT NULL,
            Street TEXT,
            City TEXT,
            State TEXT,
            ZipCode TEXT,
            AnnualSalary REAL,
            HourlyRate REAL,
            HoursWorked REAL,
            SalesAmount REAL,
            CommissionRate REAL
        );";

        using SqliteCommand command = new SqliteCommand(tableCommand, connection);
        command.ExecuteNonQuery();
    }

    public void AddEmployee(Employee employee)
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string sql =
        @"INSERT OR REPLACE INTO Employees
        (EmployeeId, FirstName, LastName, Department, EmployeeType,
         Street, City, State, ZipCode, AnnualSalary, HourlyRate,
         HoursWorked, SalesAmount, CommissionRate)
        VALUES
        (@EmployeeId, @FirstName, @LastName, @Department, @EmployeeType,
         @Street, @City, @State, @ZipCode, @AnnualSalary, @HourlyRate,
         @HoursWorked, @SalesAmount, @CommissionRate);";

        using SqliteCommand command = new SqliteCommand(sql, connection);

        command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
        command.Parameters.AddWithValue("@FirstName", employee.FirstName);
        command.Parameters.AddWithValue("@LastName", employee.LastName);
        command.Parameters.AddWithValue("@Department", employee.Department);
        command.Parameters.AddWithValue("@EmployeeType", employee.GetEmployeeType());
        command.Parameters.AddWithValue("@Street", employee.Address.Street);
        command.Parameters.AddWithValue("@City", employee.Address.City);
        command.Parameters.AddWithValue("@State", employee.Address.State);
        command.Parameters.AddWithValue("@ZipCode", employee.Address.ZipCode);

        command.Parameters.AddWithValue("@AnnualSalary", DBNull.Value);
        command.Parameters.AddWithValue("@HourlyRate", DBNull.Value);
        command.Parameters.AddWithValue("@HoursWorked", DBNull.Value);
        command.Parameters.AddWithValue("@SalesAmount", DBNull.Value);
        command.Parameters.AddWithValue("@CommissionRate", DBNull.Value);

        if (employee is SalariedEmployee salaried)
        {
            command.Parameters["@AnnualSalary"].Value = salaried.AnnualSalary;
        }
        else if (employee is HourlyEmployee hourly)
        {
            command.Parameters["@HourlyRate"].Value = hourly.HourlyRate;
            command.Parameters["@HoursWorked"].Value = hourly.HoursWorked;
        }
        else if (employee is CommissionEmployee commission)
        {
            command.Parameters["@SalesAmount"].Value = commission.SalesAmount;
            command.Parameters["@CommissionRate"].Value = commission.CommissionRate;
        }

        command.ExecuteNonQuery();
    }

    public void DisplayAllEmployees()
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string sql = "SELECT * FROM Employees;";

        using SqliteCommand command = new SqliteCommand(sql, connection);
        using SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine("Employee ID: " + reader["EmployeeId"]);
            Console.WriteLine("Name: " + reader["FirstName"] + " " + reader["LastName"]);
            Console.WriteLine("Department: " + reader["Department"]);
            Console.WriteLine("Employee Type: " + reader["EmployeeType"]);
            Console.WriteLine("Address: " + reader["Street"] + ", " + reader["City"] + ", " + reader["State"] + " " + reader["ZipCode"]);
            Console.WriteLine("------------------------------------------");
        }
    }

    public void DisplayEmployeesByType(string employeeType)
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string sql = "SELECT * FROM Employees WHERE EmployeeType = @EmployeeType;";

        using SqliteCommand command = new SqliteCommand(sql, connection);
        command.Parameters.AddWithValue("@EmployeeType", employeeType);

        using SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine("Employee ID: " + reader["EmployeeId"]);
            Console.WriteLine("Name: " + reader["FirstName"] + " " + reader["LastName"]);
            Console.WriteLine("Department: " + reader["Department"]);
            Console.WriteLine("Employee Type: " + reader["EmployeeType"]);
            Console.WriteLine("------------------------------------------");
        }
    }

    public void UpdateEmployeeDepartment(int employeeId, string newDepartment)
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string sql = "UPDATE Employees SET Department = @Department WHERE EmployeeId = @EmployeeId;";

        using SqliteCommand command = new SqliteCommand(sql, connection);
        command.Parameters.AddWithValue("@Department", newDepartment);
        command.Parameters.AddWithValue("@EmployeeId", employeeId);

        command.ExecuteNonQuery();
    }

    public void DeleteEmployee(int employeeId)
    {
        using SqliteConnection connection = new SqliteConnection(connectionString);
        connection.Open();

        string sql = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId;";

        using SqliteCommand command = new SqliteCommand(sql, connection);
        command.Parameters.AddWithValue("@EmployeeId", employeeId);

        command.ExecuteNonQuery();
    }
}