namespace HelloWorld.API.Service.Employee;

/// <summary>
/// Service to calculate Employee Annual Salaries
/// </summary>
public interface IEmployeeSalaryService
{
    /// <summary>
    /// Calculate Annual Salaries from all Employees
    /// </summary>
    /// <returns>279500</returns>
    decimal GetAnnualTotalSalary();
}