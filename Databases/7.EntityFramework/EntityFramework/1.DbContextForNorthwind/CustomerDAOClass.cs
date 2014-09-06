using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DbContextForNorthwind
{
    class CustomerDAOClass
    {
        private NorthwindDbContext northwind;

        public CustomerDAOClass()
        {
            northwind = new NorthwindDbContext();
        }

        public void AddCustomer(string customerId, string companyName)
        {
            var customer = new Customer();
            customer.CompanyName = companyName;
            customer.CustomerID = customerId;
            northwind.Customers.Add(customer);
            northwind.SaveChanges();
        }

        public void DeleteCustomer(string customerId)
        {
            var customer = northwind.Customers.FirstOrDefault(c => c.CustomerID == customerId);
            northwind.Customers.Remove(customer);
            northwind.SaveChanges();
        }

        public void UpdateCustomer(string customerId, string companyName)
        {
            var customer = northwind.Customers.FirstOrDefault(c => c.CustomerID == customerId);
            customer.CompanyName = companyName;
            northwind.SaveChanges();
        }
    }
}
