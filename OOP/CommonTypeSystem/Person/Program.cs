/*Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a person and if age is not specified – 
 * to say so. Write a program to test this functionality. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the person : ");
            string name = Console.ReadLine();
            Console.Write("Enter the age  (enter -1 if you want it to be null) : ");
            int age = int.Parse(Console.ReadLine());
            Person person;
            if (age == -1)
            {
                person = new Person(name);
            }
            else
            {
                person = new Person(name, age);
            }
            Console.WriteLine();
            Console.Write(person.ToString());
        }
    }
}
