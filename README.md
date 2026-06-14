# Employee Management System

## Overview

The Employee Management System is a C# console application designed to manage employee records using object-oriented programming principles and SQLite database storage.

This application allows users to add, update, remove, and display employee records while demonstrating key software development concepts including inheritance, polymorphism, abstraction, interfaces, composition, constructors, and database interactions.

---

## Features

### Employee Types
The system supports multiple employee types:

- Salaried Employees
- Hourly Employees
- Commission Employees

### Employee Management

Users can:

- Add new employees
- Update employee information
- Remove employees
- Display all employees
- Display employees by employee type

### Database Storage

Employee information is stored in an SQLite database, allowing records to persist between program executions.

---

## Object-Oriented Programming Concepts Demonstrated

### Inheritance
A base Employee class is extended by:

- SalariedEmployee
- HourlyEmployee
- CommissionEmployee

### Polymorphism
Employee types override methods from the Employee class to provide customized behavior.

### Abstraction
The Employee class is implemented as an abstract class.

### Interface
The application includes the IPrintable interface to define common display functionality.

### Composition
Each Employee contains an Address object demonstrating composition.

### Constructors
Constructors are used throughout the application to initialize objects.

### Access Specifiers
Public, private, and protected access specifiers are used appropriately throughout the project.

---

## Technologies Used

- C#
- .NET 8
- SQLite
- Microsoft.Data.Sqlite
- Visual Studio / Visual Studio Code
- GitHub

---

## Project Structure

```text
EmployeeManagementSystem/
│
├── Program.cs
├── Employee.cs
├── SalariedEmployee.cs
├── HourlyEmployee.cs
├── CommissionEmployee.cs
├── Address.cs
├── EmployeeDatabase.cs
├── IPrintable.cs
├── EmployeeManagement.db
└── README.md
