using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        private string sex;

        public string Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }

        public Cat(int age, string name, string sex)
            : base(age, name,sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("I am a cat, Miauu");
        }
    }
}
