
// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Interface Client App");
// Interface Reference
ITax tax;
Doctor doc = new Doctor()
{
    Name = "Dr. Abhay",
    BasicSalary = 10000,
    Fees = 400,
    MaxPatientsPerDay = 60
};


DoctorLogic doctorLogic = new DoctorLogic();

decimal doctorGross = doctorLogic.CalcluateIncome(doc);
// Interface reference for Doctor Logic
tax = new DoctorLogic();
decimal doctorTax = tax.CalculateTDS(doctorGross);
decimal doctorGST = tax.CalcluateGST(doctorGross);
Console.WriteLine($" Income for Doctor Dr. {doc.Name} with Gross as Rs. {doctorGross}/- and paybale TDS is Rs. {doctorTax}/- with GST Rs. {doctorGST}/-");


Console.WriteLine("Using Dynamic Polymorphism for Doctor Logic" );

AccontsGateway gateway = new AccontsGateway();

gateway.FindIncomeWithTDSandGSTForStaffSystem(doctorLogic, doc, tax);



Nurse nurse = new Nurse()
{
     Name = "Mrs. Spicy",
     NoOfPatientsPerWard = 20,
     BasicSalary = 6000
};

NurseLogic nurseLogic = new NurseLogic();
decimal nurseGross = nurseLogic.CalcluateIncome(nurse);
tax = new NurseLogic();
decimal nurseTDS = tax.CalculateTDS(nurseGross);
decimal nurseGST = tax.CalcluateGST(nurseGross);

Console.WriteLine($" Income for Nurse Ns. {nurse.Name} with Gross as Rs. {nurseGross}/- and paybale TDS is Rs. {nurseTDS}/- with GST Rs. {nurseGST}/-");


Console.WriteLine("Using Dynamic Polymorphism for Nurse Logic");

 // gateway = new AccontsGateway();

gateway.FindIncomeWithTDSandGSTForStaffSystem(nurseLogic, nurse, tax);




// reuse the tax reference

tax = new PatientSystem();
decimal gstToPatient = tax.CalcluateGST(1000);
decimal tdsToPatient = tax.CalculateTDS(1000);
Console.WriteLine($"GST to Patient = {gstToPatient} and TDS = {tdsToPatient}");

Console.WriteLine("Using Dynamic Polymorphism for Patients");

///gateway = new AccontsGateway();

gateway.FindIncomeWithTDSandGST(tax);


// use the sdame interface reference for Vendors also

tax = new VendorSystem();
decimal gstToVendor = tax.CalcluateGST(10000);
decimal tdsToVendor = tax.CalculateTDS(10000);
Console.WriteLine($"GST to Vendor = {gstToVendor} and TDS = {tdsToVendor}");

Console.WriteLine();


Console.WriteLine("Using Dynamic Polymorphism for Vendors");

//gateway = new AccontsGateway();

gateway.FindIncomeWithTDSandGST(tax);




Console.ReadLine();
