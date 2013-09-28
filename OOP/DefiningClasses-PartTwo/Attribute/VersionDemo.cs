using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [Version(2,11)]
    class VersionDemo
    {
        static void Main(string[] args)
        {
            Type type = typeof(VersionDemo);
            // typeof returns the type of the given thing and all its attributes
            object[] allAttributes =
              type.GetCustomAttributes(false);
            // making an object[] with all the attributes in this class
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("{0}.{1}", attr.magor, attr.minor);
                // printing the attributes properties
            }
        }
    }
}
