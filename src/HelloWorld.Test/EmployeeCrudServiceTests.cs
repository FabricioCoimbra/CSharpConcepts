using Castle.Core.Resource;
using HelloWorld.API.Controllers;
using HelloWorld.API.Model.Employee;
using HelloWorld.API.Service;
using HelloWorld.API.Service.Employee;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;

namespace HelloWorld.Test;

public class EmployeeCrudServiceTests
{
    [Fact]
    public void CreateEmployee_Success()
    {
        // Arrange
        var mockService = new EmployeeCrudService();
        var employee = new Mock<IEmployee>();

        // Act
        mockService.Create(employee.Object);

        // Assert
        Assert.NotNull(mockService.GetEmployeeById(employee.Object.Id));
    }

    [Fact]
    public void DeleteEmployee_Success()
    {
        // Arrange
        var mockService = new EmployeeCrudService();
        int id = 1;

        // Act
        mockService.Delete(id);

        // Assert
        Assert.Null(mockService.GetEmployeeById(id));
    }

    [Fact]
    public void GetEmployees_Success()
    {
        // Arrange
        var mockService = new EmployeeCrudService();

        // Act
        var result = mockService.GetEmployees();

        // Assert
        Assert.NotEmpty(result);
    }

    [Fact]
    public void GetEmployeeById_Success()
    {
        // Arrange
        var mockService = new EmployeeCrudService();
        int id = 2;

        // Act
        var result = mockService.GetEmployeeById(id);

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void UpdateEmployee_Success()
    {
        // Arrange
        string newName = "NewName";
        int id = 3;
        var mockService = new EmployeeCrudService();
        var employee = mockService.GetEmployeeById(id) ?? throw new ArgumentNullException();
        employee.Name = newName;

        // Act
        mockService.Update(employee, id);

        // Assert
        Assert.Equal(newName, mockService.GetEmployeeById(id)?.Name);
    }

    [Fact]
    public void Get_Customer_Returns_In_Client_Timezone()
    {
        // Arrange
        var utcDateTime = new DateTime(2024, 3, 29, 12, 0, 0, DateTimeKind.Utc);
        var fixedDateTimeProvider = new Func<DateTime>(() => utcDateTime);
        DateTimeProvider.SetCurrentDateTimeProvider(fixedDateTimeProvider);
        var expectedClientTime = utcDateTime.ToLocalTime();

        var mockService = new EmployeeCrudService();
        var controller = new EmployeeController(new EmployeeSalaryService(), mockService);

        // Act
        var result = controller.GetEmployee(1);

        // Assert
        Assert.NotNull(result);
        var customer = result.Value;
        Assert.NotNull(customer);
        Assert.Equal(expectedClientTime, customer.CreatedAt);
        Assert.Equal(expectedClientTime, customer.UpdatedAt);
    }
}
