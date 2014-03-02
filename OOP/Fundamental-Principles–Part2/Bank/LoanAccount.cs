using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LoanAccount : Account,IDepositable
    {
        // constructor that inherits the constructor
        // of the Account class
        public LoanAccount(Customer customer, decimal interestRate, decimal balance)
            : base(customer, interestRate, balance)
        { }

        public void Deposit(decimal value)
        {
            // when you deposit you add more money
            // to your balance
            this.Balance += value;
        }

        // overriding the CalculateInterest method
        // for each type of a customer there is a different way
        // of calculating the interest
        public override decimal CalculateInterest(int months)
        {
            decimal interest;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                // no interest if positive or less
                // than one thousand
                return 0;
            }
            else
            {
                interest = months * this.InterestRate;
            }
            return interest;
        }
    }
}
