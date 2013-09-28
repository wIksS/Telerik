using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method,
  AllowMultiple = false)]
    // this makes sure that this attribut can be used for struct
    // class interface enum and method

    public class VersionAttribute : System.Attribute
    {
        public int magor { get; private set; }
        public int minor { get; private set; }
        // making two varibles for magor and minor

        public VersionAttribute(int magor, int minor)
        {
            this.magor = magor;
            this.minor = minor;
        }
    }
}
