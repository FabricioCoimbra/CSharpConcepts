using HelloWorld.API.Service;

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
        var AnualSalary = service.GetAnualTotalSalary();

        //Assert
        Assert.Equal(expectedSalary, AnualSalary);
    }
}