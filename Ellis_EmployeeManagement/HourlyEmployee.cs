/*******************************************************************
* Name: Princess Ellis
* Date: 05/24/2026
* Purpose: Represents an hourly employee. This class inherits from
* Employee and demonstrates polymorphism.
*******************************************************************/

public class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public decimal HoursWorked { get; set; }

    public HourlyEmployee(int employeeId, string firstName, string lastName,
        string department, Address address, decimal hourlyRate,
        decimal hoursWorked)
        : base(employeeId, firstName, lastName, department, address)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }

    public override string GetEmployeeType()
    {
        return "Hourly Employee";
    }

    public override string ToString()
    {
        return base.ToString() +
               "\nHourly Rate: $" + HourlyRate +
               "\nHours Worked: " + HoursWorked;
    }
}