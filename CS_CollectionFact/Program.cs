using System.Collections;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ArrayList list = new ArrayList();

list.Add(10);
list.Add(20);
list.Add(30);
list.Add(10.3);
list.Add(20.5);
list.Add(30.7);
list.Add('a');
list.Add('b');
list.Add('c');
list.Add("ABC");
list.Add("PQR");
list.Add("LMN");

Employee e1 = new Employee();
e1.EmpNo = 101;
e1.EmpName = "Mahesh";
list.Add(e1);

Employee e2 = new Employee();
e2.EmpNo = 102;
e2.EmpName = "Neeta";
list.Add(e2);


foreach (object item in list)
{
    // for each item in collection 1. First Read its type and then 2. Read its value
    if (item.GetType() == typeof(int))
    {
        Console.WriteLine($"Type of Entry = {item.GetType()} and Value of Entry = {item}");
    }

    if (item.GetType() == typeof(Employee))
    {
        Console.WriteLine($"Type of Entry = {item.GetType()} and Value of Entry = {((Employee)item).EmpNo} {((Employee)item).EmpName}");
    }
}


public class Employee
{
    public int EmpNo;
    public string EmpName;
}


