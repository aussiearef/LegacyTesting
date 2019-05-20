using Xunit;
using Moq;
using System.Collections.Generic;

namespace SproutClass.Tests
{
    public class EmployeesTest
    {
        [Fact]
        public void GetEmployeesData_ReturnsSalaries()
        {
            var currentDataObject = new Mock<IEmployeeService>();
            currentDataObject.Setup(x => x.GetEmployeesData()).Returns(new List<Employee> (){ new Employee {UniqueId=1,Salary=100 } });
            var salaryData = currentDataObject.Object.GetEmployeesData();

            Assert.Contains(salaryData, x => x.Salary > 0);
        }
    }
}
