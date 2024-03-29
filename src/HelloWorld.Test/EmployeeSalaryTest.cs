using HelloWorld.API.Service.Employee;

namespace HelloWorld.Test;

public class EmployeeSalaryTest
{
    [Fact]
    public void TestAnualSalary()
    {
        //Arrange
        IEmployeeSalaryService service = new EmployeeSalaryService();
        var expectedSalary = 279500.0m;
        //Act
        var AnualSalary = service.GetAnnualTotalSalary();

        //Assert
        Assert.Equal(expectedSalary, AnualSalary);
    }
}