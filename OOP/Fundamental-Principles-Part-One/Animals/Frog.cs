using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(int age, string name, string sex)
            : base (age,name,sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Luf Luf Luf");
            // overriding the make sound method 
            // because every animal makes different sound
        }         
    }
}
