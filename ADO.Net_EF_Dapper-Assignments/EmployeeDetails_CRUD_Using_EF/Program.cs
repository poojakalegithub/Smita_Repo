using EmployeeDetails_CRUD_Using_EF.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeDbContext employeeDbContext = new EmployeeDbContext();
        Employee employee = new Employee();
        employee.Id = 1;
        employee.Name = "Smita";
        employee.MobileNo = "98765434";
        
        employeeDbContext.Add(employee);
        //employeeDbContext.SaveChanges();
        Console.WriteLine("Hello, World!");

    }
}