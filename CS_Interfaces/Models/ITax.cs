namespace CS_Interfaces.Models
{
    public interface ITax
    {
        decimal CalculateTDS(decimal grossIncome);
        decimal CalcluateGST(decimal bill);
    }
}
