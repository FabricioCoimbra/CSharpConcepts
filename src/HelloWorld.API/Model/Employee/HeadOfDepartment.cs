namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public class HeadOfDepartment : EmployeeBase
{
    /// <inheritdoc />
    public override decimal Salary { get => base.Salary + base.Salary * 0.03m; }
}
