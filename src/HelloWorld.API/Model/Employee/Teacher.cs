namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public class Teacher : EmployeeBase
{
    /// <inheritdoc />
    public override decimal Salary { get => base.Salary + base.Salary * 0.02m; }

}