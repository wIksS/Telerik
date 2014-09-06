using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Model;
using StudentSystem.Data;

namespace StudentSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentSystem = new StudentSystemDbContext();
            var student = new Student
            {
                Name = "Pesho"
            };

            studentSystem.Students.Add(student);
            studentSystem.SaveChanges();

            foreach (var item in studentSystem.Students)
            {
                System.Console.WriteLine(item.Name);                
            }

        }
    }
}
