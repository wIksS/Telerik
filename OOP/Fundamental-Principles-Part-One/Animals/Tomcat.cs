using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
           : base (age,name, "Female")
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau Miau");
            // overriding the make sound method 
            // because every animal makes different sound
        } 
    }
}
