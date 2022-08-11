using CS_Inmperative;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("LINQ");

EmployeeCollection employees  =  new EmployeeCollection();

Console.WriteLine("All Employees from IT DepatName");

var res1 = from e in employees
           where e.DeptName == "IT"
           select e;
Print(res1);
Console.WriteLine();
Console.WriteLine("Employee Order By EmpName");
var res2 = from e in employees
           orderby e.EmpName
           select e;
Print(res2);
Console.WriteLine();
Console.WriteLine("Print Sum Group by DeptName");
// LINQ group will create a Temp storage where the property on whick group is created 
// will be taken as 'Key', in following case DeptName is Key
// The Group has all records of same type in our case they are Employee
var res3 = (from e in employees
           group e by e.DeptName into DeptGroup // <------ The Group Resultant
           select new  // <---- The Anonymous Type (The class withiut Name) 
           {
              DeptName = DeptGroup.Key,
              Salary = DeptGroup.Sum(e=>e.Salary)
           }).ToList();
foreach (var item in res3)
{
    Console.WriteLine($"DeptName = {item.DeptName} and Salary Sum = {item.Salary}");
}

Console.WriteLine();
Console.WriteLine("Read only First 3 records");
var res4 = employees.Take(3);
Print(res4);
Console.WriteLine();
Console.WriteLine("Skip First 5 records and Print Rest of them");
var res5 = employees.Skip(5);
Print(res5);




Console.ReadLine();


static void Print(IEnumerable<Employee> emps)
{
    foreach (Employee emp in emps)
    {
        Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.DeptName}");
    }
}