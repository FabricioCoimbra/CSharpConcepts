using HelloWorld.API.Model;

namespace HelloWorld.API.Service;

public class EmployeeSalaryService : IEmployeeSalaryService
{
    public decimal GetAnualTotalSalary()
    {
        var employees = Seed();

        var total = 0m;
        foreach (var employee in employees)
        {
            total += employee.Salary;
        }

        return total;
    }
    private List<IEmployee> Seed()
    {
        List<IEmployee> result = [];

        IEmployee teatecher1 = new Teacher()
        {
            Id = 1,
            Age = 28,
            Name = "Bob Fisher",
            Salary = 40000
        };

        result.Add(teatecher1);

        IEmployee teatecher2 = new Teacher()
        {
            Id = 2,
            Age = 32,
            Name = "Thomas",
            Salary = 40000
        };

        result.Add(teatecher2);

        IEmployee headOfDepartment = new HeadOfDepartment()
        {
            Id = 3,
            Age = 35,
            Name = "Brenda",
            Salary = 50000
        };

        result.Add(headOfDepartment);

        IEmployee deputyHeadMaster = new DeputyHeadMaster()
        {
            Id = 1,
            Age = 28,
            Name = "Devlin",
            Salary = 60000
        };

        result.Add(deputyHeadMaster);

        IEmployee headMaster = new HeadMaster()
        {
            Id = 1,
            Age = 28,
            Name = "Damien",
            Salary = 80000
        };

        result.Add(headMaster);

        return result;
    }
}
