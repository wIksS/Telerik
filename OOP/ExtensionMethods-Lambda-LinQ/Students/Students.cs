using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        // making 3 variables for the 

        public Student(string firstName = null, string lastName = null, int age = 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    } 

    class Students
    {
        static void Main(string[] args)
        {
            var students = new []
            {
                new Student("Pesho", "Peshev", 16),
                new Student("Aleks", "Rodrigez", 58),
                new Student("Dimitri4ko", "AbuSaid", 3),
                new Student("Goshko", "Borkov", 109),
                new Student("Borichko","Zoro", 23),
                new Student("Nakov","Rakovski", 20),
                new Student("Moro","Krorov", 25),
                new Student("Hrosariorio","Krokodilski", 43)

            };
            // making an array of students with different parameters
            Console.WriteLine("Students with their first name before last name : \n ");

            OrderByFirstName(students);

            OrderByAge(students);

            OrderByNameLinQ(students);
            // this is oreder by first name and
            // last name by using LinQ

           // OrderByNameLambda(students);
            // this is the method for sorting
            // by first name and then last name 
            // using lambda ( i have put it in comentary)
            // because its the same like using LinQ)
        }

        static void OrderByNameLambda(Student[] students)
        {
            var orderByName = students.OrderBy(game => game.FirstName).ThenBy(game => game.LastName).Select(game => game);

            Console.WriteLine("\nOrdered by first name : \n");
            foreach (var item in orderByName)
            {
                Console.WriteLine("First Name --> {0}\nLast Name --> {1}\nAge --> {2}", item.FirstName, item.LastName, item.Age);
                Console.WriteLine(new string('-', 15));
                // this new string is just to know when the new student is being printed
            }
        }

        static void OrderByNameLinQ(Student[] students)
        {
            var orderByName = from student in students
                              orderby student.FirstName, student.LastName
                              select student;
            Console.WriteLine("\nOrdered by first name : \n");
            foreach (var item in orderByName)
            {
                Console.WriteLine("First Name --> {0}\nLast Name --> {1}\nAge --> {2}", item.FirstName, item.LastName, item.Age);
                Console.WriteLine(new string('-', 15));
                // this new string is just to know when the new student is being printed
            }
        }

        static void OrderByAge(Student[] students)
        {
            var ageBetweenStudents = from student in students
                                     where student.Age > 18 && student.Age < 24
                                     select student;

            Console.WriteLine("\nStudents with age between 18 and 24 :\n");

            foreach (var item in ageBetweenStudents)
            {
                Console.WriteLine("First Name --> {0}\nLast Name --> {1}\nAge --> {2}", item.FirstName, item.LastName, item.Age);
                Console.WriteLine(new string('-', 15));
                // this new string is just to know when the new student is being printed
            }
        }

        static void OrderByFirstName(Student[] students)
        {
            var sortedStudents = from student in students where student.FirstName.CompareTo(student.LastName) < 0 select student;

            foreach (var item in sortedStudents)
            {
                Console.WriteLine("First Name --> {0}\nLast Name --> {1}\nAge --> {2}", item.FirstName, item.LastName, item.Age);
                Console.WriteLine(new string('-',15));
                // this new string is just to know when the new student is being printed
            }
        }
    }

}
