using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        // private fields for the
        // name and age of the person
        private string name;
        private int age;

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            //using stringbuilder because it works faster than a normal string
            // and much faster then writing everything on the console
            result.AppendLine(String.Format("The person name is ---> {0}", this.name));
            if (age != 0)
            {
                result.AppendLine(String.Format("The person age is ---> {0}", this.age));
            }
            else
            {
                result.AppendLine("You havent set any value for the age of the person, so the age is null !!!");
            }
            return result.ToString();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // public property for the name
            // so it cant be accessed from anywhere
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
            // public property for the age
            // so it cant be accessed from anywhere
        }

        public Person(string name, int age = 0)
        {
            this.name = name;
            this.age = age;
            // public constructor for name and age
        }
    }
}
