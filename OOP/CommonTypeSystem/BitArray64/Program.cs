/*Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> array = new List<ulong> {1,2,4,5};
            BitArray64 opa = new BitArray64(array);
            List<ulong> array2 = new List<ulong> { 1, 2, 3, 4, 5 };
            BitArray64 opa2 = new BitArray64(array2);
            Console.WriteLine(opa!=(opa2));
        }
    }
}
