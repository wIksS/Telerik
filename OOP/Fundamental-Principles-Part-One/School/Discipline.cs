using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : ICommentable
           // it is ICommentable because it is said in the task
           // that Discipline will have comentaries
    {
        private string name;
        private int lectureNumber;
        private int excerciseNumber;
        // making three fields for the name, lectureNumber and exececiseNumer
        // like it is said in the task

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
            // a property for the Name of the Discipline
        }
        public int LectureNumber 
        {
            get { return this.lectureNumber; }
            set { this.lectureNumber = value; }
            // a property for the LectureNumber of the Discipline
        }
        public int ExcerciseNumber 
        {
            get { return this.excerciseNumber; }
            set { this.excerciseNumber = value; }
            // a property for the ExcerciseNumber of the Discipline
        }

        public Discipline(string name, int lectureNumber, int excerciseNumber)
        {
            this.name = name;
            this.lectureNumber = lectureNumber;
            this.excerciseNumber = excerciseNumber;
            // a constructor for the Discipline class
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
