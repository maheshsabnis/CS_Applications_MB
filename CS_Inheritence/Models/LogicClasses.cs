using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
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
    public  class DoctorLogic : StaffLogic
    {
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
            return grossIncome;
        }
    }


    public class NurseLogic : StaffLogic
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
    }
}
