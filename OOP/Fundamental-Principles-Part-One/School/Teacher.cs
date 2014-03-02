using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person , ICommentable
         // teacher derives from person because the teacher has a name
         // it is ICommentable because it is said in the task
         // that SchoolClasses will have comentaries
    {
        private List<Discipline> disciplines;
        // making a list of dicsiplines because every 
        // teacher has multiple disciplines

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set { this.disciplines = value; }
            // a property for the list of disciplines
        }

        public Teacher(string name)
        {
            this.Name = name;
            this.disciplines = new List<Discipline>();
            //a proprty for the name of the teacher
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
