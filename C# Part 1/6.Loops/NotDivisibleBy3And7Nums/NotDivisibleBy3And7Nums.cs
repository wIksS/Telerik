//  Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NotDivisibleBy3And7Nums
{
    static void Main()
    {
        Console.Write("Inset number N : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                if (i == n)
                {
                    Console.Write(i);
                }
                else if (i < n)
                {
                    Console.Write("{0} , ", i);
                }
            }
        }
        Console.WriteLine();
    }
}

