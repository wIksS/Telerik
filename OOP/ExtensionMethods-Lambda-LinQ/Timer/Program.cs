using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void DelegateTSeconds();

    class Program
    {
        static int seconds;
        public static void Main()
        {
            Console.Write("Enter the each \"t\" seconds you want the method to be runned : ");
            seconds = int.Parse(Console.ReadLine());
            Tester t = new Tester(seconds);
            t.Run();
        }
        
        public static void TestMethod()
        {
            Console.WriteLine("This method happens each \"{0}\" seconds using delegates !!!!!!",seconds);
            // I m making a test method just to see that 
            // the method is running every second
        }
    }
}
