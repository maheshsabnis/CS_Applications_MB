

namespace CS_Interfaces.Models
{
    /// <summary>
    /// The class which cannot be Instantiated
    /// </summary>
    public abstract class StaffLogic
    {
        public abstract List<Staff> Get();
        public abstract Staff Get(int id);
        public abstract Staff Register(Staff staff);
        public abstract Staff Update(int id, Staff staff);
        public abstract bool Delete(int id);

        /// <summary>
        /// A Default Implementation for Staff to Calculate Income
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public virtual decimal CalcluateIncome(Staff staff)
        {
            return staff.BasicSalary;
        }
    }

    /// <summary>
    /// MUST Override all abstract methods
    /// Since Doctor is-a Staff, we can pass the the Doctor as an input parameter
    /// as-well-as we can have Doctor as an output parameter at Run-Time and not as Compile-Time
    /// This is a 'Runtime or Dynamic Polymorphism'
    /// </summary>
    public  class DoctorLogic : StaffLogic , ITax
    {
        private decimal GrossIncome = 0;
        public override List<Staff> Get()
        {
            throw new NotImplementedException(); 
        }
        public override Staff Get(int id)
        {
            throw new NotImplementedException();
        }
        public override Staff Register(Staff staff)
        {
            throw new NotImplementedException();
        }

        public override Staff Update(int id, Staff staff)
        {
            throw new NotImplementedException();
        }
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }


        public override decimal CalcluateIncome(Staff staff)
        {
            decimal perDayIncome = ((Doctor)staff).MaxPatientsPerDay * ((Doctor)staff).Fees;
            decimal monthlyFees = perDayIncome * 30;
            // Get the basic Salary  
            decimal grossIncome = base.CalcluateIncome(staff) + monthlyFees;
            GrossIncome = grossIncome;  
            return grossIncome;
        }

        /// <summary>
        /// Implicit Implementation
        /// </summary>
        /// <param name="grossIncome"></param>
        /// <returns></returns>
        //public decimal CalculateTDS(decimal grossIncome)
        //{
        //    return grossIncome * Convert.ToDecimal(0.1);
        //}

        decimal ITax.CalculateTDS(decimal grossIncome)
        {
            return grossIncome * Convert.ToDecimal(0.1);
        }
        /// <summary>
        /// Implicit Implementation
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        //public decimal CalcluateGST(decimal bill)
        //{
        //    return bill * Convert.ToDecimal(0.18);
        //}
        decimal ITax.CalcluateGST(decimal bill)
        {
            return bill * Convert.ToDecimal(0.18);
        }
    }


    public class NurseLogic : StaffLogic, ITax
    {
        
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public override Staff Register(Staff staff)
        {
            throw new NotImplementedException();
        }
        public override Staff Update(int id, Staff staff)
        {
            throw new NotImplementedException();
        }
        public override Staff Get(int id)
        {
            throw new NotImplementedException();
        }
        public override List<Staff> Get()
        {
            throw new NotImplementedException();
        }

        public override decimal CalcluateIncome(Staff staff)
        {
            decimal collectionPerDay = ((Nurse)staff).NoOfPatientsPerWard * 400;
            decimal monthlyCollection = collectionPerDay * 30;
            decimal grossCololection = base.CalcluateIncome(staff) + monthlyCollection;
            return grossCololection;
        }

        /// <summary>
        /// Explicit Implementation
        /// </summary>
        /// <param name="bill"></param>
        /// <returns></returns>
        decimal ITax.CalcluateGST(decimal bill)
        {
            return bill * Convert.ToDecimal(0.05);
        }
        /// <summary>
        /// Explicit
        /// </summary>
        /// <param name="grossIncome"></param>
        /// <returns></returns>
        decimal ITax.CalculateTDS(decimal grossIncome)
        {
            return grossIncome * Convert.ToDecimal(0.03);
        }
    }

}
