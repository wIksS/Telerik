using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string name;
        private List<SchoolClass> schoolClasses;
        //i am making a list of classes like it is said in the tast
        // and also a name for the school
        // (which is optonal and I decided to do it)

        public List<SchoolClass> Classes
        {
            get { return this.schoolClasses; }
            set { this.schoolClasses = value; }
            //a property for the list of classes
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // a property for the name of the school
        }

        public School (string name)
        {
            this.name = name;
            this.schoolClasses = new List<SchoolClass>();
            // constructor for the school
        }
    }
}
