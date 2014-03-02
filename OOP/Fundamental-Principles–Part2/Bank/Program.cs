using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customersList = new List<Customer>();
            customersList.Add(new Individual());
            customersList.Add(new Individual());
            customersList.Add(new Company());
            customersList.Add(new Company());
            customersList.Add(new Company());
            List<Account> accountsList = new List<Account>();
            accountsList.Add(new DepositAccount(customersList[0], 1010, 0.06m)); // same parameteres to see the diference
            accountsList.Add(new DepositAccount(customersList[1], 2000, 0.1m));
            accountsList.Add(new DepositAccount(customersList[2], 1000, 0.06m));
            accountsList.Add(new LoanAccount(customersList[3], 1000, 0.06m)); //after override
            accountsList.Add(new MortageAccount(customersList[4], 1000, 0.06m));

            foreach (var account in accountsList)
            {
                Console.WriteLine(account.CalculateInterest(10));
                account.Deposit(2000);
                if (account is DepositAccount)
                {
                    account.Widraw(100);
                    Console.WriteLine("I 've just drow out some money");
                }
            }
        }
    }
}
