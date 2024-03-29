using HelloWorld.API.Model;

namespace HelloWorld.API.Service;

public partial class EmployeeSalaryService
{
    internal static class EmployeeFactory
    {
        internal static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string name, decimal salary, int age)
        {
            IEmployee? employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher()
                    {
                        Name = name,
                        Salary = salary,
                        Age = age,
                        Id = id
                    };
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment
                    {
                        Name = name,
                        Salary = salary,
                        Age = age,
                        Id = id
                    };
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = new DeputyHeadMaster()
                    {
                        Name = name,
                        Salary = salary,
                        Age = age,
                        Id = id
                    };
                    break;
                case EmployeeType.HeadMaster:
                    employee = new  HeadMaster()
                    {
                        Name = name,
                        Salary = salary,
                        Age = age,
                        Id = id
                    };
                    break;
                default:
                    break;
            }
            //if (employee != null)
            //{
            //    employee.Id = id;
            //    employee.Name = name;
            //    employee.LastName = lastName;
            //    employee.Salary = salary;
            //}
            //else
            //    throw new NullReferenceException();

            ArgumentNullException.ThrowIfNull(employee);
            return employee;

        }
    }

}
