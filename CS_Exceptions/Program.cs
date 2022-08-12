// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exception Handling");

Employee employee = new Employee() { EmpNo=-9, EmpName=null, Salary=900 };
BusinessProcess process = new BusinessProcess();
try
{
    var emps = process.Add(employee);
    foreach (var item in emps)
    {
        Console.WriteLine($"{item.EmpNo} {item.EmpName} {item.Salary}");
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Errpr ===> {ex.Message}" );
}
Console.ReadLine();



public class Employee
{
    public int EmpNo { get; set; }
    public String EmpName { get; set; } = String.Empty;
    public decimal Salary { get; set; }
}

public class BusinessProcess
{
    List<Employee> employees = new List<Employee>();

    public List<Employee> Add(Employee emp)
    {
        try
        {
            if (emp.EmpNo <= 0) throw new Exception("EmpNo Cannot be -Ve");
            if (String.IsNullOrEmpty(emp.EmpName)) throw new Exception("EmpName cannt be null or empty");

            employees.Add(emp);

        }
        catch (Exception ex)
        {
            // Log the Error
            Console.WriteLine($"Some Error Occured while adding Employee {ex.Message}");
            // Throw the error again
            throw ex;
        }
        
        return employees;
    }
}



