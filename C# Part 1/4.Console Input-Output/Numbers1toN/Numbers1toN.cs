using System;

class Numbers1toN
{
    static void Main()
    {
        Console.Write("Insert a number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers from 1 to n are :");
        Console.Write("1");
        for (int i = 2; i < n; i++)
        {
            Console.Write(" , {0}",i);
        }
        Console.Write(" , {0}",n);
        Console.WriteLine();
    }
}

