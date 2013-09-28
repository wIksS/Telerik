//  Write a program that prints all the numbers from 1 to N.

using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.Write("Inset number N : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i==n)
            {
               Console.Write(i); 
            }
            if (i < n)
            {
                Console.Write("{0} , ", i);
            }
        }
        Console.WriteLine();
    }
}

