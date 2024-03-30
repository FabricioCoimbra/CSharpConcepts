using HelloWorld.API.Model.Employee;
using HelloWorld.API.Service.Employee;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.API.Controllers;
/// <summary>
/// Beautiful controller to use only one responsibility. Call the service.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeSalaryService employeeSalaryService;
    private readonly IEmployeeCrudService crudService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="employeeSalaryService"></param>
    /// <param name="crudService"></param>
    public EmployeeController(IEmployeeSalaryService employeeSalaryService, IEmployeeCrudService crudService)
    {
        this.employeeSalaryService = employeeSalaryService;
        this.crudService = crudService;
    }
    /// <summary>
    /// Get total of annual salary of all employees.
    /// </summary>
    /// <returns>279500.0m</returns>
    [HttpGet("salary")]
    public ActionResult<DateTime> GetAnnualTotalSalary(DateTime date) =>
        Ok(employeeSalaryService.GetAnnualTotalSalary());

    /// <summary>
    /// Get list of all employees
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<IEnumerable<EmployeeBase>> GetEmployees()
    {
        List<EmployeeBase> employees = [];
        foreach (var item in crudService.GetEmployees())
            employees.Add((EmployeeBase)item);

        return employees;
    }

    /// <summary>
    /// Get Employee by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public ActionResult<EmployeeBase> GetEmployee(int id)
    {
        var employee = crudService.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return (EmployeeBase)employee;
    }

    /// <summary>
    /// Create e new Employee
    /// </summary>
    /// <param name="employee"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<EmployeeBase> CreateEmployee([FromBody] Teacher employee)
    {
        crudService.Create(employee);
        return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
    }

    /// <summary>
    /// Update exiting Employee
    /// </summary>
    /// <param name="id"></param>
    /// <param name="employee"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(int id, Teacher employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }

        var existingEmployee = crudService.GetEmployeeById(id);
        if (existingEmployee == null)
        {
            return NotFound();
        }

        crudService.Update(employee, id);

        return NoContent();
    }

    /// <summary>
    /// Delete Employee
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(int id)
    {
        var employee = crudService.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }

        crudService.Delete(id);
        return NoContent();
    }
}
