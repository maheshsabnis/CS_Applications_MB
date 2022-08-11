 
using System.Threading.Tasks;

namespace CS_Interfaces.Models
{
    public class PatientSystem : ITax
    {
        decimal ITax.CalcluateGST(decimal bill)
        {
            return bill * Convert.ToDecimal(0.02);
        }

        decimal ITax.CalculateTDS(decimal grossIncome)
        {
            return grossIncome * Convert.ToDecimal(0.015);
        }
    }
}
