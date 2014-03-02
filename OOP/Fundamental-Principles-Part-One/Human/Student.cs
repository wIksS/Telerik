using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Student : Human
    {
        private int grade;
        // a field for grade like it is said in the task

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
            // a property for the grade of the student  
        }

        public Student (int grade, string firstName, string lastName)
        {
            this.grade = grade;
            this.FirstName = firstName;
            this.LastName = lastName;
            // a constructor for the student class
        }
    }
}
