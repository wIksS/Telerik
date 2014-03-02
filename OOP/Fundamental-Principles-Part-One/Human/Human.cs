using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        // making fields for first name and last name
        // like it is said in the task

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
            // a property for the first name of the Human
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
            // a property for the last name of the Human
        }
    }
}
