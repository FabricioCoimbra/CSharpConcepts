using HelloWorld.API.Model.Employee;

namespace HelloWorld.API.Service.Employee;

internal static class EmployeeFactory
{
    internal static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string name, decimal salary, int age)
    {
        IEmployee employee = employeeType switch
        {
            EmployeeType.Teacher => FactoryPattern<IEmployee, Teacher>.GetInstance(),
            EmployeeType.HeadOfDepartment => FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance(),
            EmployeeType.DeputyHeadMaster => FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance(),
            EmployeeType.HeadMaster => FactoryPattern<IEmployee, HeadMaster>.GetInstance(),
            _ => throw new NullReferenceException(),
        };
        employee.Id = id;
        employee.Name = name;
        employee.Age = age;
        employee.Salary = salary;

        return employee;
    }
}
