using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GenericListApps
{
    internal class Program
    {
        static List<Employee> Employees;
        static void Main(string[] args)
        {
            Console.WriteLine("Using Generic List");
            // Initializing the Collection While Declaring
              Employees = new List<Employee>()
            {
                new Employee() { EmpNo=101,EmpName="Mahesh", Salary=12345, DeptName="IT1", Designation="Manager1"},
                new Employee() { EmpNo=102,EmpName="Vikram", Salary=22345, DeptName="IT2", Designation="Manager2"},
                new Employee() { EmpNo=103,EmpName="Suprotim", Salary=32345, DeptName="IT3", Designation="Manager1"},
                new Employee() { EmpNo=104,EmpName="Manish", Salary=42345, DeptName="IT4", Designation="Manager2"},
                new Employee() { EmpNo=105,EmpName="Pravin", Salary=52345, DeptName="IT5", Designation="Manager1"},
                new Employee() { EmpNo=106,EmpName="Abhijeet", Salary=62345, DeptName="IT5", Designation="Manager2"},
                new Employee() { EmpNo=107,EmpName="Subodd", Salary=72345, DeptName="IT4", Designation="Manager1"},
                new Employee() { EmpNo=108,EmpName="Shriniwas", Salary=82345, DeptName="IT3", Designation="Manager2"},
                new Employee() { EmpNo=109,EmpName="Saket", Salary=92345, DeptName="IT2", Designation="Manager1"},
                new Employee() { EmpNo=110,EmpName="Sachin", Salary=12340, DeptName="IT1", Designation="Manager2"},

            };

            // Manipulare the List Data
            Console.WriteLine("All records");
            PrintAll();
            Console.WriteLine("After Insert");

            Employees.Insert(5, new Employee() { EmpNo = 205, EmpName = "Deepak", Salary = 82340, DeptName = "IT2", Designation = "Manager1" });
            PrintAll();
            Console.WriteLine();
            Console.WriteLine("After Remove");

            Employees.RemoveAt(5);
            Console.WriteLine();
            
            Console.WriteLine();
            PrintAll();
            Console.WriteLine();

            PrintByDeptName("IT2");


            


            Console.ReadLine();
        }
        static void PrintAll()
        {
            foreach (Employee emp in Employees)
            {
                    Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.Designation}");
            }
        }

        static void PrintByDeptName(string dname)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.DeptName.Trim() == dname.Trim())
                {
                    Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.Designation}");
                }
            }
        }
    }

    /// <summary>
    /// Class with Auto-Implemented Properties
    /// </summary>
    public class Employee
    { 
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string DeptName { get; set; }
        public string Designation { get; set; }
    }
}
