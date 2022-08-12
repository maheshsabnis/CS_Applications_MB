using System.Threading.Tasks;
using CS_Simple_Tasks;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task with the Return Value");

// define a Task that will collect data from the Task running inside the Factory

Task<int> TResult = Task.Factory.StartNew(() => {
    int result = Add(100,200);
    Console.WriteLine($"result on the Task = {result}");
    // Return it
    return result;
});

// Collect the value on Main Thread

Console.WriteLine($"Lets get the value of Main Thread from TResult = {TResult.Result}");

Console.WriteLine();
Console.WriteLine("A Bit Complex Example");


Task<List<Employee>> EmpListResult = Task.Factory.StartNew(() => 
{
    var emps = GetEmployeesOrderByName();
    return emps;
});

Console.WriteLine("Paint on Main Thread");

var result = EmpListResult.Result;

foreach (var item in result)
{
    Console.WriteLine($"{item.Salary} {item.EmpName}");
}

Console.ReadLine();


static int Add(int x,int y)
{ 
    return x + y;
}


static List<Employee> GetEmployeesOrderByName()
{
    var employees = new EmployeeList();

    var emps = (from e in employees 
               orderby e.EmpName descending
               select e).ToList();

    return emps;
}

