using HelloWorld.API.Model.Employee;

namespace HelloWorld.API.Service.Employee;

internal class EmployeeCrudService : IEmployeeCrudService
{
    private readonly List<IEmployee> employees = EmployeeSalaryService.Seed();
    public List<IEmployee> GetEmployees() => employees;
    public IEmployee? GetEmployeeById(int id)
    {
        var employee = employees.FirstOrDefault(x => x.Id == id);
        if (employee is not null)
        {
            employee.CreatedAt = employee.CreatedAt.ToLocalTime();
            employee.UpdatedAt = employee.UpdatedAt.ToLocalTime();
        }

        return employee;
    }

    public void Create(IEmployee employee)
    {
        employee.CreatedAt = DateTimeProvider.GetUTCDateTime();
        employee.UpdatedAt = DateTimeProvider.GetUTCDateTime();
        employees.Add(employee);
    }

    public void Update(IEmployee employee, int id)
    {
        var updated = GetEmployeeById(id);
        if (updated != null)
        {
            employee.CreatedAt = updated.CreatedAt;
            Delete(id);
            employee.UpdatedAt = DateTimeProvider.GetUTCDateTime();
            employees.Add(employee);
        }
    }

    public void Delete(int id)
    {
        var employee = GetEmployeeById(id);
        if (employee != null)
            employees.Remove(employee);
    }
}
