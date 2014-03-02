using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass : ICommentable
        // it is ICommentable because it is said in the task
        // that SchoolClasses will have comentaries
    {
        private List<Student> students;
        private List<Teacher> teachers;
        public List<string> Comments { get; set; }
        private string classID;
        // making a list of students and teachers like 
        // it is said in the task and
        // a string for the text identificator of the class and 
        // a list of string for the comments

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
            // a property for the list of students
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
            // a property for the list of teachers
        }

        public SchoolClass(string classID)
        {
            this.classID = classID;
            students = new List<Student>();
            teachers = new List<Teacher>();
            // a constructor for the schoolclass
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
            // here I add a comment to the list of comments
            // like it is needed in the interface
        }
    }
}
