using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger sum = 0;
        BigInteger previousNumber = 0;
        BigInteger currentNumber = 1;
        BigInteger fiboNumber = 0;
        for (int i = 0; i < n; i++)
        {
            fiboNumber = previousNumber + currentNumber;
            previousNumber = currentNumber;
            currentNumber = fiboNumber;
            sum += fiboNumber;
        }
            Console.WriteLine("The sum of the first {0} members is : {1}",n,sum);
        
    }
}

