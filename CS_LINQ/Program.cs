using CS_LINQ;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO LINQ");
EmployeeCollection employees = new EmployeeCollection();

// 1. Print all Employees having name length greayter than 10
var res1 = employees.Where(e=>e.EmpName.Length > 10);
Console.WriteLine("Employees having EmpName Length Greater than 10");
Print(res1);
Console.WriteLine();
Console.WriteLine("Sort Employees by Salary");
var res2 = employees.OrderBy(e=>e.Salary); 
Print(res2);
Console.WriteLine();
Console.WriteLine("Employees only from IT DeptName");
var res3 = employees.Where(e=>e.DeptName == "IT").ToList();
Print(res3);
Console.WriteLine();
Console.WriteLine("Employee From IT DeptName with Name Length greater than 10");

var res4 = employees.Where(e => e.DeptName == "IT").Where(e=>e.EmpName.Length > 10);
Print(res4);
Console.WriteLine();
Console.WriteLine("All EMployees from IT DEptName order by Salary");
var res5 = employees.Where(e => e.DeptName == "IT").OrderBy(e=>e.Salary); 
Print(res5);







Console.ReadLine(); 


static void Print(IEnumerable<Employee> emps)
{
    foreach (Employee emp in emps)
    {
        Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.DeptName}");
    }
}