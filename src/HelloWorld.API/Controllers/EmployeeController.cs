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
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="employeeSalaryService"></param>
    public EmployeeController(IEmployeeSalaryService employeeSalaryService)
    {
        this.employeeSalaryService = employeeSalaryService;
    }
    /// <summary>
    /// Get total of annual salary of all employees.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult GetAnnualTotalSalary() =>
        Ok(employeeSalaryService.GetAnnualTotalSalary());
}
