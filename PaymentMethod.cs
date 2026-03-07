using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class PaymentMethod
    {
        //Shared Between All Payment Methods
        /*
         * Balance -> has private set
         * Charge(amount) method -> is virtual and overridden
         */
        // Differences
        /*
         * DebitCard: cannot go below 0
         * CreditCard: can go negative until -CreditLimit 
         */

        private decimal balance;
        // readable from outside
        public decimal Balance => balance;
        //  no one should be able to set it directly 
        protected void SetBalance(decimal _balance) => balance = _balance;

        public PaymentMethod(decimal _balance)
        {
            balance = _balance;
        }

        // Default charge behavior
        public virtual bool Charge(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }



    }
}
