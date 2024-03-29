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
                employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
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

        return employee;
    }
}
