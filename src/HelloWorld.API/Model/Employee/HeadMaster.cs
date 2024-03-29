namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public class HeadMaster : EmployeeBase
{
    /// <inheritdoc />
    public override decimal Salary { get => base.Salary + base.Salary * 0.05m; }
}
