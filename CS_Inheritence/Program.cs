using CS_Inheritence.Models;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("The Staff System");

Accounts accounts = new Accounts();

Doctor doc = new Doctor();
doc.Name = "Dr. Anil";
doc.MaxPatientsPerDay = 100;
doc.Fees = 350;

StaffLogic logic = new DoctorLogic();
accounts.FindStaffIncome(logic, doc);

Nurse nurse = new Nurse();
nurse.Name = "Ms. Benza";
nurse.NoOfPatientsPerWard = 40;

logic = new NurseLogic();
accounts.FindStaffIncome(logic, nurse);



Console.ReadLine();


public class Accounts
{
    /// <summary>
    /// Dynmaic Polymorphism for deciding the Logic Class Instance and Staff Type 
    /// </summary>
    /// <param name="logic"></param>
    /// <param name="staff"></param>
    public void FindStaffIncome(StaffLogic logic, Staff staff)
    {
        decimal income = logic.CalcluateIncome(staff);
        Console.WriteLine($"Salarty of Staff {staff.Name} is  = Rs.{logic.CalcluateIncome(staff)}/-");
    }
}
