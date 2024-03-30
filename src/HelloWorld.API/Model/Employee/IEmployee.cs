namespace HelloWorld.API.Model.Employee;

/// <summary>
/// Definition of base employee
/// </summary>
public interface IEmployee
{
    /// <summary>
    /// Unique code to identify this Employee
    /// </summary>
    int Id { get; set; }
    /// <summary>
    /// Name of employee
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// The salary for this position
    /// </summary>
    decimal Salary { get; set; }
    /// <summary>
    /// Age of employee
    /// </summary>
    int Age { get; set; }
    /// <summary>
    /// Creation time
    /// </summary>
    DateTime CreatedAt { get; set; }
    /// <summary>
    /// Last updated time
    /// </summary>
    DateTime UpdatedAt { get; set; }
}
