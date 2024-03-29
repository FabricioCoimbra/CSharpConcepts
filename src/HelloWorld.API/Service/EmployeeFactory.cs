using HelloWorld.API.Model;

namespace HelloWorld.API.Service;

internal static class EmployeeFactory
{
    internal static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string name, decimal salary, int age)
    {
        IEmployee? employee = null;

        switch (employeeType)
        {
            case EmployeeType.Teacher:
                employee = new Teacher();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = new HeadOfDepartment();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = new DeputyHeadMaster();
                break;
            case EmployeeType.HeadMaster:
                employee = new HeadMaster();
                break;
            default:
                break;
        }
        if (employee != null)
        {
            employee.Id = id;
            employee.Name = name;
            employee.Age = age;
            employee.Salary = salary;
        }
        else
            throw new NullReferenceException();

        ArgumentNullException.ThrowIfNull(employee);
        return employee;
    }
}
