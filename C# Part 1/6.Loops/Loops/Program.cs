using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert how many prime numbers do you want : ");
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int divider=2; divider < n; divider++)
            {
                if ((n % divider==0))
                {
                    prime = false;
                }
                
            }
            Console.WriteLine(prime);
            //if (prime = false)
            //{
            //    Console.WriteLine("The number isnt prime");
            //}
            //else
            //{
            //    Console.WriteLine("The number is prime ! ");
            //}
        }
    }
}
