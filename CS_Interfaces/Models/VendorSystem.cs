using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interfaces.Models
{
    public class VendorSystem : ITax
    {
        decimal ITax.CalcluateGST(decimal bill)
        {
            return bill * Convert.ToDecimal(0.18);
        }

        decimal ITax.CalculateTDS(decimal grossIncome)
        {
            return grossIncome * Convert.ToDecimal(0.1);
        }
    }
}
