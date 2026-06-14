# Employee Management System

## Overview

The Employee Management System is a C# console application designed to manage employee records using object-oriented programming principles and SQLite database storage.

This application allows users to add, update, remove, and display employee records while demonstrating key software development concepts including inheritance, polymorphism, abstraction, interfaces, composition, constructors, access specifiers, and database interactions.

---

## Features

### Employee Types

The system supports three employee types:

- Salaried Employees
- Hourly Employees
- Commission Employees

### Employee Management Functions

Users can:

- Add new employees
- Update existing employee information
- Remove employees
- Display all employees
- Display employees by employee type
- Store employee records in a database

### Database Storage

Employee information is stored in an SQLite database, allowing records to persist between program executions.

---

## Object-Oriented Programming Concepts Demonstrated

### Inheritance

The application uses inheritance through a base Employee class and the following derived classes:

- SalariedEmployee
- HourlyEmployee
- CommissionEmployee

### Polymorphism

Each employee type overrides inherited methods to provide customized behavior while still being treated as Employee objects.

### Abstraction

The Employee class is implemented as an abstract class to provide common functionality for all employee types.

### Interface

The application includes the IPrintable interface to define common display and printing functionality.

### Composition

Each Employee object contains an Address object, demonstrating composition.

### Constructors

Constructors are used throughout the project to initialize employee and address objects.

### Access Specifiers

The project makes use of:

- Public
- Private
- Protected

access specifiers to ensure proper encapsulation and security.

---

## Technologies Used

- C#
- .NET 8
- SQLite
- Microsoft.Data.Sqlite
- Visual Studio Code
- GitHub

---

## Project Structure

```text
EmployeeManagementSystem
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
├── README.md
├── bin/
└── obj/
```

---

## Program Workflow

1. Application starts and displays a welcome message.
2. User selects an option from the menu.
3. User can:
   - Add employees
   - Update employee information
   - Remove employees
   - Display all employees
   - Display employees by employee type
4. Employee information is saved to the SQLite database.
5. The application continues running until the user selects Exit.

---

## Sample Menu

```text
========================================
EMPLOYEE MANAGEMENT SYSTEM
========================================

1. Add Employee
2. Update Employee
3. Remove Employee
4. Display All Employees
5. Display Employees By Type
6. Exit

Enter Choice:
```

---

## Installation Instructions

1. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/EmployeeManagementSystem.git
```

2. Open the project in Visual Studio Code or Visual Studio.

3. Restore dependencies:

```bash
dotnet restore
```

4. Build the project:

```bash
dotnet build
```

5. Run the application:

```bash
dotnet run
```

---

## Demonstration Video

YouTube Demonstration Video:

**PASTE YOUR YOUTUBE VIDEO LINK HERE**

The demonstration video includes:

- Project overview
- Review of source code
- Inheritance demonstration
- Interface demonstration
- Abstract class demonstration
- Composition demonstration
- Database functionality
- Adding employees
- Updating employees
- Removing employees
- Displaying employee records

---

## GitHub Tags

### Phase #1
Initial project implementation demonstrating inheritance and composition.

### Final Phase
Completed application including:

- Inheritance
- Polymorphism
- Interfaces
- Abstract Classes
- Constructors
- Access Specifiers
- Composition
- SQLite Database Integration
- Full Employee Management Functionality

---

## Author

**Princess Ellis**

Software Development Student

---
