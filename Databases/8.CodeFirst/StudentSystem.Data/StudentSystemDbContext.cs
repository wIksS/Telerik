using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Model;
using System.Data.Entity;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Course> Courses { get; set; }

    }
}
