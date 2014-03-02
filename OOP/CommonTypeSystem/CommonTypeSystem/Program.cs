/*(Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, 
universities and faculties. Override the standard methods, inherited by  
System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string opa = "aaaa";
            string dze = "aaza";
            Console.WriteLine(opa.CompareTo(dze));
        }
    }
}
