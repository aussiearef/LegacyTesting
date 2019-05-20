using System.Collections.Generic;
using System.Linq;

namespace SproutClass
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeesData()
        {
            var result = new List<Employee>();

            // var listFromdb = databaseService.GetEmployees();
            // add the list of employees to the 'result' object

            // Sample data:
            result.Add(new Employee {FirstName="Harry", LastName="Potter", UniqueId=1 });

            var salaryDataService = new EmployeeSalaryService();
            var salaries = salaryDataService.GetEmployeesData();

            result.ForEach(x => {
                var salaryData = salaries.First(y => y.UniqueId == x.UniqueId);
                x.Salary = salaryData.Salary;
            });

            return result;
        }
    }
}
