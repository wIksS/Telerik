using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(int age, string name, string sex)
            :base (age,name,sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("GUUUOb GUUUOOB FRoogG");
            // overriding the make sound method 
            // because every animal makes different sound
            // couldnt think of a better sound for the frog            
        } 
    }
}    
    
