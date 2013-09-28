//  Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
//  Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.


class MinAndMaxNums
{
    static void Main()
    {
        Console.WriteLine("Input total number N for reading :");
        Console.Write("n = ");
        string nStr = Console.ReadLine();
        long smallestNumber=long.MaxValue;
        long biggestNumber=0;
        int n = int.Parse(nStr);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Input number :");
            string xStr = Console.ReadLine();
            long x = long.Parse(xStr);
            
            if (x<smallestNumber)
            {
                smallestNumber = x;
            }
            if (x>biggestNumber)
            {
                biggestNumber = x;
            }
        }
        Console.WriteLine("The biggest number is {0}\nThe smallest number is {1}",biggestNumber,smallestNumber);
    }
}

