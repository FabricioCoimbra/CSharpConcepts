namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public class DeputyHeadMaster : EmployeeBase
{
    /// <inheritdoc />
    public override decimal Salary { get => base.Salary + base.Salary * 0.04m; }
}
