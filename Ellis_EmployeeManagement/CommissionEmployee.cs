/*******************************************************************
* Name: Princess Ellis
* Date: 05/24/2026
* Purpose: Represents a commission employee. This class inherits from
* Employee and demonstrates polymorphism.
*******************************************************************/

public class CommissionEmployee : Employee
{
    public decimal SalesAmount { get; set; }
    public decimal CommissionRate { get; set; }

    public CommissionEmployee(int employeeId, string firstName, string lastName,
        string department, Address address, decimal salesAmount,
        decimal commissionRate)
        : base(employeeId, firstName, lastName, department, address)
    {
        SalesAmount = salesAmount;
        CommissionRate = commissionRate;
    }

    public override decimal CalculatePay()
    {
        return SalesAmount * CommissionRate;
    }

    public override string GetEmployeeType()
    {
        return "Commission Employee";
    }

    public override string ToString()
    {
        return base.ToString() +
               "\nSales Amount: $" + SalesAmount +
               "\nCommission Rate: " + CommissionRate;
    }
}