//  * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).


using System;
using System.Collections.Generic;

class GenericMethod
{
    static void Main(string[] args)
    {
        decimal max = Max(213.21m, 32.34m, 231.123m, 54.12354m);
        decimal min = Min(213.21m, 32.34m, 231.123m, 54.12354m);
        decimal sum = Sum(213.21m, 32.34m, 231.123m, 54.12354m);
        decimal average = Average(213.21m, 32.34m, 231.123m, 54.12354m);
        decimal product = Product(213.21m, 32.34m, 231.123m, 54.12354m);
        Console.WriteLine("Max = {0}\n Min = {1}\nSum = {2}\nAverage = {3}\nProduct = {4}", max, min, sum, average, product);
    }

    static T Product<T>(params T[] sequence)
    {
        dynamic product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static T Average<T>(params T[] sequence)
    {
        dynamic sum = 0;
        int i = 0;
        for (i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / i;
    }

    static T Sum<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static T Max<T>(params T[] sequence)
    {
        dynamic max = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (max < sequence[i])
            {
                max = sequence[i];
            }
        }
        return max;
    }

    static T Min<T>(params T[] sequence)
    {
        dynamic min = sequence[0];
        for (int i = 1; i < sequence.Length; i++)
        {
            if (min > sequence[i])
            {
                min = sequence[i];
            }
        }
        return min;
    }
}

