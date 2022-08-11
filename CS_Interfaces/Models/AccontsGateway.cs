namespace CS_Interfaces.Models
{
    public class AccontsGateway
    {
        /// <summary>
        /// Dynamic Polymorphism for StaffLogic, Staff and Interfac ITax
        /// </summary>
        /// <param name="logic"></param>
        /// <param name="staff"></param>
        /// <param name="tx"></param>
        public void FindIncomeWithTDSandGSTForStaffSystem(StaffLogic logic, Staff staff, ITax tx)
        {
            decimal income = logic.CalcluateIncome(staff);
            decimal tds = tx.CalculateTDS(income);
            decimal gst = tx.CalcluateGST(income);

            Console.WriteLine($"Income = {income} and TDS = {tds} and GST = {gst}");
        }

        /// <summary>
        /// Dyna,mic Polymprphism using ITax interface
        /// </summary>
        /// <param name="tx"></param>
        public void FindIncomeWithTDSandGST(ITax tx)
        {
            decimal tds = tx.CalculateTDS(10000);
            decimal gst = tx.CalcluateGST(10000);

            Console.WriteLine($"TDS = {tds} and GST = {gst}");
        }
    }
}
