using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events
{
    // 1. Declare a delegate that will be used to define events
    // The return type will be void because event notifications are always One-Way

    public delegate void TransactionHandler(double amount);

    public class Banking
    {

        // 2. Declare events

        public event TransactionHandler OverBalance;
        public event TransactionHandler UnderBalance;

        double OpeningBanalce = 0;
        public Banking(double opbanalance)
        {
            OpeningBanalce = opbanalance;
        }

        public void Deposit(double amt)
        {
            OpeningBanalce += amt;

            if (OpeningBanalce > 100000)
            {
                // 3. Raise an event
                // The OpeningBanalce is data for the Notification 
                OverBalance(OpeningBanalce);
            }
        }

        public void Withdrawal(double amt)
        {
            OpeningBanalce -= amt;
            if (OpeningBanalce < 6000)
            {
                // 3. Raise an Event
                // The OpeningBanalce is data for the Notification 
                UnderBalance(OpeningBanalce);
            }
        }

        public double GetBalance()
        {
            return OpeningBanalce;
        }
    }



    /// <summary>
    /// This class will be known by Caller and Banking
    /// </summary>
    public class EventListener
    { 
        Banking banking;
        /// <summary>
        /// Link the EventListener with Banking
        /// so that when the bank rains an event, it will be processed
        /// </summary>
        /// <param name="banking"></param>
        public EventListener(Banking banking)
        {
            this.banking = banking;
            // Create  Notification Methods that will be sending Transaction Information to
            // Client

            banking.OverBalance += Banking_OverBalance;
            banking.UnderBalance += Banking_UnderBalance;
        }

        /// <summary>
        /// The Method that will be linked with an event
        /// so that when an event is raised this method will be
        /// Invoked
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Banking_UnderBalance(double amount)
        {
            Console.WriteLine($"Sir, your Netbalance is Rs. {amount}/- so please keep minimum Rs.6000/- in Acccount, otherwisae ther will be deactivation");
        }

        /// <summary>
        /// The Method that will be linked with an event
        /// so that when an event is raised this method will be
        /// Invoked
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Banking_OverBalance(double amount)
        {
            double TaxableAmount = amount - 100000;
            double Tax = TaxableAmount * 0.1;

            Console.WriteLine($"Dear Sir, Your Net Nalance is Rs. {amount}/- which is Rs.{TaxableAmount}/- more tha Rs.100000, so please pay tax of Rs. {Tax}/- else Madam Sitraram will Capture you");
        }
    }
}
