namespace HelloWorld.API.Model.Employee;

/// <inheritdoc />
public abstract class EmployeeBase : IEmployee
{
    /// <summary>
    /// Unique code to identify this Employee
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Name of employee
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// The salary for this position
    /// </summary>
    public virtual decimal Salary { get; set; }
    /// <summary>
    /// Age of employee
    /// </summary>
    public int Age { get; set; }
    /// <summary>
    /// Creation time
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// Last updated time
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}
