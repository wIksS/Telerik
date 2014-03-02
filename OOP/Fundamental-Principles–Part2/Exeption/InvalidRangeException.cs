using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    public class InvalidRangeException<T> : Exception
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        // all those interfaces confirm that
        // the T can only be number (int,float,decimal) or datetime
    {
        // start and end for the class
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            :base (message)
        {
            Start = start;
            End = end;
        }

        // property for start
        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        // property for end
        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
