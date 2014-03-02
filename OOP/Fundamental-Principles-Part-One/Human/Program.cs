using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(5,"Nako","Banakov"),
                new Student(2,"4op4o","Hruskov"),
                new Student(3,"Him4o","Trypkov"),
                new Student(4,"Kliombo","Shliopkov"),
                new Student(2,"Pesho","Meshev"),
                new Student(6,"Kolio","Fi4eto"),
                new Student(6,"Deneris","Targarien"),
                new Student(5,"Brand","Stark"),
                new Student(3,"Djon","Snow"),
                new Student(2,"Planinata","Hrytkata"),
            };

            students = students.OrderByDescending(student => student.Grade).ToList();
            // using lambda and the ToList method to sort the students
            Console.WriteLine("Students : ");

            foreach (var student in students)
            {
                Console.WriteLine("Grade : {0} | Full name : {1} {2}",student.Grade,student.FirstName,student.LastName);
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker(250,8,"Vinetu","Djonkov"),
                new Worker(1000,5,"Porazqvashtata","Ryka"),
                new Worker(5000,2,"Peiko","Slaveikov"),
                new Worker(3144,3,"","Djonkov"),
                new Worker(5435,12,"Old","ShaterHand"),
                new Worker(43535,24,"OtPochivka","Gosheto"),
                new Worker(534,3,"ARandomNameHere","CantThinkOfAnythingBetter"),
                new Worker(22,12,"IToveEGoshetoSyshto","Gosheto00oOoOOOOoOo"),
                new Worker(2,8,"StrannoIme","OshtePoStrannoIme"),
                new Worker(432423,2,"Devil","Lucifer"),
            };

            workers = workers.OrderByDescending(worker => worker.MoneysPerHour).ToList();
            // using lambda and the ToList method to sort the workers
            Console.WriteLine("\nWorkers : ");

            foreach (var worker in workers)
            {
                Console.WriteLine("Money per hour : {0} | Full name : {1} {2}", worker.MoneysPerHour, worker.FirstName, worker.LastName);
            }

            var workersAndStudents = students.Concat<Human>(workers).ToList();
            workersAndStudents = workersAndStudents.OrderByDescending(human => human.FirstName).ThenByDescending(human => human.LastName).ToList();
            // using lambda and the ToList method to sort the workers and the students
            Console.WriteLine("\nWorkers and Students : ");

            foreach (var human in workersAndStudents)
            {
                Console.WriteLine("Full name --> {0} {1}", human.FirstName, human.LastName);
            }            
        }
    }
}
