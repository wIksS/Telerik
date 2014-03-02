using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;
        // fields for sex , name and age for the animal class
        // like it is said in the example

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
            // property for age
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
            // property for sex
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // property for name
        }

        public Animal(int age, string name, string sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Grrr");
        }
    }
}
