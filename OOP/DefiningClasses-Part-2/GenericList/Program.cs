using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> opa = new GenericList<string>();
            opa.Add("fdsafsadffdsasdf");
            opa.Add("dfadf");
            opa.Add("fdaf");
            opa.Add("afd");
            opa.InsertElement(2, "Dobavi meee");
            Console.WriteLine(opa.ToString());
            Console.WriteLine(opa.Min<string>());
            Console.WriteLine(opa[2]);
        }
    }
}
