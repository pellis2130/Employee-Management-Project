/*******************************************************************
* Name: Princess Ellis
* Date: 05/24/2026
* Purpose: Abstract base class for all employee types. Demonstrates
* abstraction, inheritance, and interface implementation.
*******************************************************************/

public abstract class Employee : IPrintable
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }

    // Composition: Employee has an Address.
    public Address Address { get; set; }

    public Employee(int employeeId, string firstName, string lastName,
        string department, Address address)
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
        Address = address;
    }

    public abstract decimal CalculatePay();

    public abstract string GetEmployeeType();

    public virtual string GetDisplayInfo()
    {
        return ToString();
    }

    public override string ToString()
    {
        return "Employee ID: " + EmployeeId +
               "\nName: " + FirstName + " " + LastName +
               "\nDepartment: " + Department +
               "\nEmployee Type: " + GetEmployeeType() +
               "\nAddress: " + Address +
               "\nCalculated Pay: $" + CalculatePay();
    }
}