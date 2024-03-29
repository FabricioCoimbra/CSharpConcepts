using HelloWorld.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeSalaryService employeeSalaryService;

    public EmployeeController(IEmployeeSalaryService employeeSalaryService)
    {
        this.employeeSalaryService = employeeSalaryService;
    }
    [HttpGet]
    public ActionResult GetAnualTotalSalary() =>
        Ok(employeeSalaryService.GetAnualTotalSalary());
}
