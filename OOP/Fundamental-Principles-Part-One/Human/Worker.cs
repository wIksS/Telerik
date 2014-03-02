using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;
        // fields for week salary and work hours per day
        // like it is said in the task
 
        public Worker(int weekSalary, int workHoursPerDay, string firstName, string lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
            this.FirstName = firstName;
            this.LastName = lastName;
            MoneyPerHour();
            // a constructor for the Worker class
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
            // a property for the weekSalary of the Worker  
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
            // a property for the workHoursPerDay of the Worker  
        }

        public decimal MoneyPerHour()
        {
            this.moneyPerHour = ((decimal)this.weekSalary / 5.0M) / (decimal)this.workHoursPerDay;
            return moneyPerHour;
            // this is a formula i invented and i am 
            // not entirely sure it is true
        }

        public decimal MoneysPerHour
        {
            get { return this.moneyPerHour; }
        }
    }
}
