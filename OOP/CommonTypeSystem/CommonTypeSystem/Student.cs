using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    public class Student : ICloneable , IComparable<Student>
    {
        // private fields for all the 
        // date mentioned in the task
        private string firstName;
        private string secondName;
        private string lastName;
        private ulong SSN;
        private string permanentAdress;
        private ulong mobilePhone;
        private string email;
        private string course;
        private Speciality specialities;
        private University universities;
        private Faculty faculties;

        public Student(string firstName, string secondName, string lastName, ulong SSN, string permanentAdress,
            ulong mobilePhone, string email, string course, Speciality speciality, University university, Faculty faculty)
        {                                                                                                                                                     
            this.firstName = firstName;                                                                                                                        
            this.secondName = secondName;
            this.lastName = lastName;
            this.SSN = SSN;
            this.permanentAdress = permanentAdress;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.course = course;
            this.specialities = specialities;
            this.universities = universities;
            this.faculties = faculties;
            // public constructor for the class
        }

        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            if (student == null)
            {
                return false;                
            }           

            if (student.firstName == this.firstName && student.secondName == this.secondName && student.lastName == this.lastName && student.SSN == this.SSN && student.permanentAdress == permanentAdress &&
                student.mobilePhone == mobilePhone)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("First name --> {0}", this.firstName));
            result.AppendLine(String.Format("Second name --> {0}", this.secondName));
            result.AppendLine(String.Format("Last name --> {0}", this.lastName));
            result.AppendLine(String.Format("SSN --> {0}", this.SSN));
            result.AppendLine(String.Format("Permanent adress --> {0}", this.permanentAdress));
            result.AppendLine(String.Format("Mobile phone --> {0}", this.mobilePhone));
            result.AppendLine(String.Format("Email --> {0}", this.email));
            result.AppendLine(String.Format("Course --> {0}", this.course));
            result.AppendLine(String.Format("Specialities : {0}",this.specialities));
            result.AppendLine(String.Format("Universities : {0}", this.universities));
            result.AppendLine(String.Format("Faculties : {0}", this.faculties));
            //foreach (var speciality in this.specialities)
            //{
            //    result.Append(speciality + " ");
            //}
            //foreach (var university in this.universities)
            //{
            //    result.Append(university + " ");
            //}
            //foreach (var faculty in this.faculties)
            //{
            //    result.Append(faculty + " ");
            //}
            return result.ToString();
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (!firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public ulong SSNNum
        {
            get { return this.SSN; }
            set { this.SSN = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public string PermanentAdress
        {
            get { return this.permanentAdress; }
            set { this.permanentAdress = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public ulong MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public Speciality Specialities
        {
            get { return this.specialities; }
            set { this.specialities = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public University Universities
        {
            get { return this.universities; }
            set { this.universities = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }
        public Faculty Faculties
        {
            get { return this.faculties; }
            set { this.faculties = value; }
            // a public property for the private field
            // so the field cant be accessed from everywhere
        }

        public Student Clone()
        {
            Student student = new Student(this.firstName, this.secondName, this.lastName,
                this.SSN, this.PermanentAdress, this.mobilePhone, this.email,
                this.course, this.specialities, this.universities, this.faculties);

            return student;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.firstName.CompareTo(other.firstName) == -1)
            {
                return -1;
            }
            else if (this.firstName.CompareTo(other.FirstName) == 0)
            {
                if (this.SSN > other.SSN)
                {
                    return -1;
                }
                else if (this.SSN < other.SSN)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.firstName.CompareTo(other.firstName) == 1)
            {
                return 1;
            }
            return -1;
        }
    }
}
