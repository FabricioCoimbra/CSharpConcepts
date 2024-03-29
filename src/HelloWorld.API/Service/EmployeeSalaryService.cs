using HelloWorld.API.Model;

namespace HelloWorld.API.Service;

public partial class EmployeeSalaryService : IEmployeeSalaryService
{
    public decimal GetAnualTotalSalary()
    {
        return Seed().Sum(e => e.Salary);
    }
    private List<IEmployee> Seed()
    {
        List<IEmployee> result = [];

        IEmployee teatecher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob Fisher", 40000, 28);
        result.Add(teatecher1);

        IEmployee teatecher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Thomas", 40000, 32);
        result.Add(teatecher2);

        IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Brenda", 50000, 35);
        result.Add(headOfDepartment);

        IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Devlin", 60000, 28);
        result.Add(deputyHeadMaster);

        IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 5, "Damien", 80000, 28);
        result.Add(headMaster);

        return result;
    }

}
