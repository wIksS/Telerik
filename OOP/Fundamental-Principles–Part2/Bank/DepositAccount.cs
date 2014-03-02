using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount : Account, IDepositable,IDraw
    {
        // constructor that inherits the constructor
        // of the Account class
        public DepositAccount(Customer customer, decimal interestRate, decimal balance)
            : base(customer, interestRate, balance)
        { }

        public void Deposit(decimal money)
        {           
            // when you deposit you add more money
            // to your balance
            this.Balance += money;
        }

        public override void Widraw(decimal money)
        {
            // when you widraw you take money
            // from your balance
            this.Balance -= money;

        }

        // overriding the CalculateInterest method
        // for each type of a customer there is a different way
        // of calculating the interest
        public override decimal CalculateInterest(int months)
        {
            decimal interest;
            if (this.Customer is Individual && months > 3)
            {
                interest = months * this.InterestRate;
            }
            else if (this.Customer is Company && months > 2)
            {
                interest = months * this.InterestRate;
            }
            else
            {
                // if none meet the requirements
                return 0;
            }
            return interest;
        }
    }
}
