using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DbContextForNorthwind
{
    class Program
    {
        static void Main(string[] args)
        {
            // Second task
            CustomerDAOClass customerDAO = new CustomerDAOClass();
            // customerDAO.AddCustomer("slabo","Pesho");
            var northwind = new NorthwindDbContext();
            //Third task
            var customers = from order in northwind.Orders
                            where order.OrderDate.Value.Year == 1997 && order.ShipCountry == "Canada"
                            select order;

            Console.WriteLine("Customers with linq : ");
            foreach (var order in customers.ToList())
            {
                Console.WriteLine(order.Employee.FirstName);
            }


            // Fourth task
            string nativeSQLQuery = "SELECT DISTINCT e.FirstName  FROM Orders o " +
                                    "JOIN Employees e" +
                                    "ON o.EmployeeID = e.EmployeeID" +
                                    "WHERE YEAR( o.OrderDate) = {0} AND o.ShipCountry = '{1}'";

            object[] parameters = { 1997, "Canada" };

            var secondCustomers = northwind.Database.SqlQuery<string>(string.Format(nativeSQLQuery, parameters));

            Console.WriteLine("\nCustomers with native sql query : ");
            foreach (var order in customers.ToList())
            {
                Console.WriteLine(order.Employee.FirstName);
            }

            //Fifth task
            DateTime firstDate = new DateTime(1997, 3, 3);
            DateTime secondDate = new DateTime(2014, 3, 3);
            string region = "RJ";
            var sales = FindSales(northwind, firstDate, secondDate, region);

            foreach (var sale in sales)
            {
                Console.WriteLine("Ship --> {0} at {1}",sale.ShipName,sale.OrderDate.Value);
            }
            Console.WriteLine();

            // Sixth task
            var northwind2 = new NorthwindDbContext();

            var firstDbEmployee = northwind.Employees.First();
            var secondDbEmployee = northwind2.Employees.First();
            Console.WriteLine(firstDbEmployee.FirstName);
            Console.WriteLine(secondDbEmployee.FirstName);
            firstDbEmployee.FirstName = "pesho";
            secondDbEmployee.FirstName = "peshkata";
            Console.WriteLine(firstDbEmployee.FirstName);
            Console.WriteLine(secondDbEmployee.FirstName);
            northwind.SaveChanges();
            northwind2.SaveChanges();

            // Eighth task
            using (var transaction = northwind.Database.BeginTransaction())
            {
                for (int i = 0; i < 15; i++)
                {
                    var order = new Order();
                    order.OrderDate = DateTime.Now;
                    order.ShipName = "Pesho";
                    northwind.Orders.Add(order);
                }

                northwind.SaveChanges();
                transaction.Commit();
            }

            Console.WriteLine("Transaction finished !");
            //DateTime startDate = new DateTime(1990,12,12);
            //DateTime endDate = new DateTime(2014,12,12);

            //Tenth task
            GetTotalIncome(1990, 2014, "Exotic Liquids");
        }

        static void GetTotalIncome(int startYear, int endYear, string companyName)
        {
            

            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                SqlParameter startYearParam = new SqlParameter("@startYear", startYear);
                SqlParameter endYearParam = new SqlParameter("@endYear", endYear);
                SqlParameter name = new SqlParameter("@companyName", companyName);

                var income = db.Database.ExecuteSqlCommand("usp_FindTotalIncome @startYear, @endYear, @companyName", startYearParam, endYearParam, name);

                Console.WriteLine("Total income is {0}", income);
            }
        }

        private static IQueryable<Order> FindSales(NorthwindDbContext northwind, DateTime firstDate, DateTime secondDate, string region)
        {
            var sales = from o in northwind.Orders
                        where o.OrderDate.Value > firstDate && o.OrderDate < secondDate
                        && o.ShipRegion == region
                        select o;
            return sales;
        }
    }
}
