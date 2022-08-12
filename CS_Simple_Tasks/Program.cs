using System.Threading.Tasks;
using System.Diagnostics;
using CS_Simple_Tasks.Models;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Simple Tasks");
// The Main Thread is now asking CLR to organize the execution by creating a Schedular
// implictly
Task task = Task.Factory.StartNew(() => { PerformOperations(); });
Console.WriteLine("Back to Main Thread");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Main Thread i = {i}");
}

Console.ReadLine(); 

static void PerformOperations()
{
    var timer = new Stopwatch();
    timer.Start();
    Task t1 = new Task(() => { Console.WriteLine("Task 1");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Task 1 i = {i}");
        }
    });
    Task t2 = new Task(() => { Console.WriteLine("Task 2");
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Task 2 i = {i}");
        }
    });
    Task t3 = new Task(() => { Console.WriteLine("Task 3"); });

    t1.Start();
    t1.Wait(); // Other Tasks will be executed only when the t1 is done with its job
    t2.Start();
    t3.Start();
    // Wait for all Tasks to COmplete
    Task.WaitAll(t1, t2, t3);
    Console.WriteLine("All Previous Tasks have done its job");
    Task t4 = new Task(() => {
        var employees = new EmployeeList();
        Parallel.For(0, employees.Count, (int i) =>
        {
            employees[i] = ProcessTax.CalculateTax(employees[i]);
            Console.WriteLine($"In Parallel Execution Tax for EmpName {employees[i].EmpName} is = {employees[i].Tax}");
            Thread.Sleep(100);
            i++;
        });
    });
    t4.Start();
    timer.Stop();
    Console.WriteLine($"Total Time to Execute the method on Task = {timer.Elapsed.TotalSeconds}");
}
