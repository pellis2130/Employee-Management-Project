/*******************************************************************
* Name: Princess Ellis
* Date: 05/24/2026
* Purpose: Represents a salaried employee. This class inherits from
* Employee and demonstrates polymorphism.
*******************************************************************/

public class SalariedEmployee : Employee
{
    public decimal AnnualSalary { get; set; }

    public SalariedEmployee(int employeeId, string firstName, string lastName,
        string department, Address address, decimal annualSalary)
        : base(employeeId, firstName, lastName, department, address)
    {
        AnnualSalary = annualSalary;
    }

    public override decimal CalculatePay()
    {
        return AnnualSalary / 12;
    }

    public override string GetEmployeeType()
    {
        return "Salaried Employee";
    }

    public override string ToString()
    {
        return base.ToString() +
               "\nAnnual Salary: $" + AnnualSalary;
    }
}