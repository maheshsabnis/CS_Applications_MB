using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstInt = new List<int>();
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);
            lstInt.Add(40);

            foreach (int item in lstInt)
            {
                Console.WriteLine(item);
            }

            List<string> lstString = new List<string>();
            lstString.Add("Mahesh");
            lstString.Add("Leena");
            lstString.Add("Tejas");

            foreach (string item in lstString)
            {
                Console.WriteLine(item);
            }

            List<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee() { EmpNo = 101, EmpName = "Mahesh" });
            lstEmp.Add(new Employee() { EmpNo = 102, EmpName = "Teajs" });


            foreach (Employee item in lstEmp)
            {
                Console.WriteLine(item.EmpNo + "  " + item.EmpName);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpNo;
        public string EmpName;
    }
}
