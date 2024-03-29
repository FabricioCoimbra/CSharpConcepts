namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public abstract class EmployeeBase : IEmployee
{
    /// <inheritdoc />
    public int Id { get; set; }
    /// <inheritdoc />
    public string Name { get; set; } = null!;
    /// <inheritdoc />
    public virtual decimal Salary { get; set; }
    /// <inheritdoc />
    public int Age { get; set; }
}
