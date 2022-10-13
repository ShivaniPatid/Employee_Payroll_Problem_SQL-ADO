namespace EmployeePayrollProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to employee payroll");

            EmployeeModel model = new EmployeeModel();
            EmployeeRepo repo = new EmployeeRepo();

            model.EmployeeName = "Roanak";
            model.PhoneNumber = 9999999999;
            model.Address = "Pune";
            model.Department = "HR";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.TaxablePay = 200;
            model.Tax = 300;
            model.NetPay = 2500;
            model.City = "Pune";
            model.Country = "India";

            //repo.AddEmployee(model);
            repo.GetAllEmployee();
            
        }
    }
}