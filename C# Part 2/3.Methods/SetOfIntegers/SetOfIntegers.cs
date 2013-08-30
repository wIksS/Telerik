//  Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;

class SetOfIntegers
{
    static void Main(string[] args)
    {
        int max = Max(213,32,231,54);
        int min = Min(213, 32 , 231, 54);
        int sum = Sum(213, 32, 231, 54);
        int average = Average(213, 32, 231, 54);
        int product = Product(213, 32, 231, 54);
        Console.WriteLine("Max = {0}\n Min = {1}\nSum = {2}\nAverage = {3}\nProduct = {4}",max,min,sum,average,product);
    }

    static int Product(params int[] sequence)
    {
        int product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static int Average(params int[] sequence)
    {
        int sum = 0;
        int i = 0;
        for (i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / i;
    }

    static int Sum(params int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static int Max(params int[] sequence)
    {
        int max = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (max<sequence[i])
            {
                max = sequence[i];
            }
        }
        return max;
    }

    static int Min(params int[] sequence)
    {
        int min = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (min>sequence[i])
            {
                min = sequence[i];
            }
        }
        return min;
    }
}

