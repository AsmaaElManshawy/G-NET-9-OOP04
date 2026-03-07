using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class CreditCard : PaymentMethod
    {
        public decimal CreditLimit { get; }

        public CreditCard(decimal balance, decimal creditLimit) : base(balance)
        {
            CreditLimit = creditLimit;
        }

        public override bool Charge(decimal amount)
        {
            if (Balance - amount >= -CreditLimit)
            {
                SetBalance(Balance - amount);
                return true;
            }

            return false;
        }
    }
}
