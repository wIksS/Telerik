using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface ICommentable
        // making an interface for the classes 
        // who can have comments
    {
        List<string> Comments { get; set; }
        // the class should have a list of comments

        void AddComment(string comment);
        // the class should have a method to add something to those comments
    }
}
