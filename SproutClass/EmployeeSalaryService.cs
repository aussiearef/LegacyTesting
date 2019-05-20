using System.Collections.Generic;

namespace SproutClass
{
    public class EmployeeSalaryService : IEmployeeService
    {
        public List<Employee> GetEmployeesData()
        {
            return new List<Employee>() { new Employee {UniqueId=1, Salary=100 } };
        }
    }
}
