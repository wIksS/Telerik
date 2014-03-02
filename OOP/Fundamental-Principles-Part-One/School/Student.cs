using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person, ICommentable
          // Student derives from person because the Student has a name
          // it is ICommentable because it is said in the task
          // that SchoolClasses will have comentaries
    {
        private string classID;
        // making a field classID for the student
        // like it is said in the task

        public string ClassID
        {
            get { return this.classID; }
            set { this.classID = value; }
            // a property for the class id
        }

        public Student(string name, string classID)
        {
            this.Name = name;
            this.classID = classID;
            // a property for the name of the student
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
            // here I add a comment to the list of comments
            // like it is needed in the interface
        }
    }
}
