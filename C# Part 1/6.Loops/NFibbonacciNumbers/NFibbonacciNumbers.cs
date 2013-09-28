//  Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the              first two) is a sum of the previous two members.

using System;
using System.Numerics;

class NFibbonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers do you want : ");
        int n = int.Parse(Console.ReadLine());
        BigInteger previousNum = 0;
        BigInteger currentNum = 1;
        BigInteger fiboNum=0;
        for (int i = 0; i < n; i++)
        {
            fiboNum = previousNum + currentNum;
            previousNum = currentNum;
            currentNum = fiboNum;
            Console.WriteLine("{0} ",fiboNum);
        }
    }
}

