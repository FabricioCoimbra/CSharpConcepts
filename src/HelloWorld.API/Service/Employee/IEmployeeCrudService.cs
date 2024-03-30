using HelloWorld.API.Model.Employee;

namespace HelloWorld.API.Service.Employee;

/// <summary>
/// Provide a full CRUD operations from Employee
/// </summary>
public interface IEmployeeCrudService
{
    /// <summary>
    /// Create e new Employee
    /// </summary>
    /// <param name="employee"></param>
    /// <returns></returns>
    void Create(IEmployee employee);
    /// <summary>
    /// Delete Employee
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    void Delete(int id);
    /// <summary>
    /// Get list of all employees
    /// </summary>
    /// <returns></returns>
    List<IEmployee> GetEmployees();
    /// <summary>
    /// Get Employee by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    IEmployee? GetEmployeeById(int id);
    /// <summary>
    /// Update exiting Employee
    /// </summary>
    /// <param name="id"></param>
    /// <param name="employee"></param>
    /// <returns></returns>
    void Update(IEmployee employee, int id);
}