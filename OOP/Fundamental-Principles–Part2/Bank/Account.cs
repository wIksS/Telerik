using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // an abstarct class which inherits
    // the IDepositable interface
    public class Account : IDepositable,IDraw
    {
        // fields for the three things
        // that an account possess
        private decimal interestRate;
        private decimal balance;
        private Customer customer;

        // an abstact method which all inheritants
        // should posses
        public virtual decimal CalculateInterest(int months)
        {
            return this.interestRate * months;
        }

        public virtual void Deposit(decimal money)
        {
        }

        public virtual void Widraw(decimal money)
        {
        }

        // constructor for all the fields in the class
        public Account(Customer customer, decimal interestRate, decimal balance)
        {
            this.customer = customer;
            this.interestRate = interestRate;
            this.balance = balance;
        }

        // a property for the field
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        // a property for the field
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        // a property for the field
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
    }
}
