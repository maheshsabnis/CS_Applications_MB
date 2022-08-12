// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Dictionary");

Dictionary<int, string> dict = new Dictionary<int, string>();

dict.Add(1, "Mahesh");
dict.Add(2, "Vikram");
dict.Add(3, "Subodh");
dict.Add(4, "Manish");
dict.Add(5, "Pravin");
// dict.Add(5, "Ramesh"); // Error

foreach (var key in dict.Keys)
{
    Console.WriteLine($"Value at {key} is = {dict.TryGetValue(key, out string name)} ");
    Console.WriteLine($"Name  =  {name}" );
}


 

Dictionary<string, List<Employee>> EmployeesDB = new Dictionary<string, List<Employee>>();

EmployeesDB.Add("IT", new List<Employee>() { new Employee() { EmpNo = 101, EmpName = "Tejas", Salary = 12345 }, new Employee() { EmpNo = 102, EmpName = "Mahesh", Salary = 22345 } });

EmployeesDB.Add("HRD", new List<Employee>() { new Employee() { EmpNo = 201, EmpName = "Amar", Salary = 52345 }, new Employee() { EmpNo = 202, EmpName = "Kumar", Salary = 22545 }, new Employee() { EmpNo = 203, EmpName = "Nikhil", Salary = 26545 } });


EmployeesDB.TryGetValue("IT", out List<Employee> emps);

foreach (var emp in emps)
{
    Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary}");
}


Console.ReadLine();

public record Employee
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; } = string.Empty;
    public decimal Salary { get; set; }
}