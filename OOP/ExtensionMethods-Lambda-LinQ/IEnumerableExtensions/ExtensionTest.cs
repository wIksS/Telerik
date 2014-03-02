using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class ExtesionsTest
    {
        static void Main()
        {
            Console.Write("Enter the length of the array : ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            // it can be an array of double and decimal also
            // you can change it if you want and it will work

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element number {0} : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum : " + array.Sum());
            Console.WriteLine("Min : " + array.ExtendedMin());
            // I have named it extended min because there are too
            // many extension methods for Min() and its hard to find the one you need
            Console.WriteLine("Max : " + array.ExtendedMax());
            // the same goes for max
            Console.WriteLine("Product : " + array.Product());
            Console.WriteLine("Average : " + array.Average());
        }
    }
}
