using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private string sex;
        // a field for sex

        public string Sex
        {
            get { return this.sex; }
            // a read only field for sex because tomcats and
            // kittens can have only one sex
        }

        public Kitten(int age, string name)
            : base (age,name,"Male")
        {
           
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miauuuuuuu Miauuuuuuuuuuuu");
            // overriding the make sound method 
            // because every animal makes different sound
        } 
    }
}
