using EmployeePayrollProblem;

namespace TestProjectForEmployeePayroll
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetailsAbleToUpdate()
        {
            //Arrange
            Salary salary = new Salary();
            SalaryUpdateModel salaryUpdateModel = new SalaryUpdateModel()
            {
                SalaryID = 3,
                Month = "June",
                EmployeeSalary = 30000,
                EmployeeID = 3
            };

            //Act
            int EMpSalary = salary.UpdateEmployeeSalary(salaryUpdateModel);

            //Assert
            Assert.AreEqual(salaryUpdateModel.EmployeeSalary, EMpSalary);

        }
    }
}