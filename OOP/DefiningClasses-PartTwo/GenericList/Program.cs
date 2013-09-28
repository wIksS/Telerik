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
            GenericList<int> opa = new GenericList<int>(1);
            opa.Add(1);
            opa.Add(2);
            opa.Add(3);
            opa.Add(4);
            opa.InsertElement(2, 0);
            Console.WriteLine(opa.Min<int>());
        }
    }
}
