using CS_SimpleClass.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_SimpleClass
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple OOPs");
            string option = "y";

            do
            {

                // Instance creation that will call
                // The COnstructor
                StaffLogicList logic = new StaffLogicList();

                Console.WriteLine("1. Get Staff");
                Console.WriteLine("2. Register New Staff");
                Console.WriteLine("3. Update Staff By Id");
                Console.WriteLine("4. Delete Staff By Id");


                Console.WriteLine("Enter the Choice");

                int selection = Convert.ToInt32(Console.ReadLine());

                List<Staff> staffs;

                switch (selection)
                {
                    case 1:
                        staffs = logic.GetStaffs();
                        Print(staffs);
                        break;
                    case 2:
                        // Define an instance of Staff
                        // Initize property values
                        // using the Object Initializer
                        // The default COnstructor will be called
                        Staff staff = new Staff()
                        {
                            StaffId = 1001,
                            StaffName = "Mahesh",
                            Address = "Pune",
                            StaffCategory = "Doctor",
                            DeptName = "Cancer",
                            Income = 23400,
                            Fees = 600,
                            Ward = "General",
                            Room = "Gen-Rm-001"
                        };
                        staffs = logic.Register(staff);
                        Print(staffs);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter y to Continue");
                option = Console.ReadLine();
                Console.Clear();
            } while (option == "y");

            Console.ReadLine();
        }

        static void Print(List<Staff> array)
        {
            foreach (Staff staff in array)
            {
                Console.WriteLine($"{staff.StaffId} {staff.StaffName} {staff.StaffCategory}");
            }
        }
    }
}