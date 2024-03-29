using BenchmarkDotNet.Attributes;
using HelloWorld.API.Service;

namespace HelloWorld.Benchmark;

[MemoryDiagnoser]
public class BenchmarkEmployeeSalary
{
    private readonly IEmployeeSalaryService _employeeSalaryService = new EmployeeSalaryService();

    [Benchmark]
    public void MeasureAnualTotalSalary()
    {
        _employeeSalaryService.GetAnualTotalSalary();
    }
}
