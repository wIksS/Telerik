using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        private string name;
        // making a field name for the person

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // a property for the name of the person
        }
    }
}
