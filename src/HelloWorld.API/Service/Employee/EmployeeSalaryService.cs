﻿using HelloWorld.API.Model.Employee;

namespace HelloWorld.API.Service.Employee;

/// <inheritdoc />
public class EmployeeSalaryService : IEmployeeSalaryService
{
    private readonly List<IEmployee> employees = Seed();
    /// <inheritdoc />
    public decimal GetAnnualTotalSalary() =>
        employees.Sum(e => e.Salary);
    internal static List<IEmployee> Seed() =>
    [
        EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob Fisher", 40000, 28),
        EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Thomas", 40000, 32),
        EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda", 50000, 35),
        EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Devlin", 60000, 28),
        EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", 80000, 28)
    ];
}
