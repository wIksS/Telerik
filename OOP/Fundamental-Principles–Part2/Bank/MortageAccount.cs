using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MortageAccount : Account, IDepositable
    {
        // constructor that inherits the constructor
        // of the Account class
        public MortageAccount(Customer customer, decimal interestRate, decimal balance)
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
            if (this.Customer is Company && months < 12)
            {
                interest = (months * this.InterestRate) / 2;
            }
            else if (this.Customer is Individual && months < 6)
            {
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
