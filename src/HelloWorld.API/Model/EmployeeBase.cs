namespace HelloWorld.API.Model;

public abstract class EmployeeBase : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual decimal Salary { get; set; }
    public int Age { get; set; }
}
