using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        // making an extension method with is applied to all objects
        // who have the iEnumareble interface
        public static T Sum<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic sum = 0;
            // making an element of T from the first element of the list

            foreach (var item in list)
            {
                sum += item;
                // I add every element to the sum
            }
            // returning the sum
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            dynamic sum = 1;
            // making it dynamic because otherwise
            // i cant use it in generics

            foreach (var item in list)
            {
                sum *= item;
                // I add every element to the sum
            }
            // returning the sum
            return sum;
        }

        // I named it extended min because there is already a defined method for min
        // and it is hard to find this one exactly if its name was just min
        public static T ExtendedMin<T>(this IEnumerable<T> list)
            where T : IComparable
        // It is IComparable because i need i have to compare all the items
        // in order to see witch one of them is the smallest
        {
            dynamic min = int.MaxValue;

            foreach (var item in list)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                    // if item is smaller than min
                    // min = item                    
                }
            }
            return min;
        }

        // I named it extended max because there is already a defined method for min
        // and it is hard to find this one exactly if its name was just min
        public static T ExtendedMax<T>(this IEnumerable<T> list)
    where T : IComparable
        // It is IComparable because i need i have to compare all the items
        // in order to see witch one of them is the smallest
        {
            dynamic max = int.MinValue;

            foreach (var item in list)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                    // if item is biiger than max
                    // min = item                    
                }
            }
            return max;
        }

        public static decimal Avarage<T>(this IEnumerable<T> list)
            where T : IComparable
        {
            decimal average;
            dynamic sum = 0;
            int count = 0;
            // making 3 variables needed to find the average

            foreach (var item in list)
            {
                sum += item;
                count++;
                // adding each element to the sum 
                // and the count ++
            }

            average = (decimal)sum / (decimal)count;
            return average;
            // returning the average with is sum / count
        }
    }
}
