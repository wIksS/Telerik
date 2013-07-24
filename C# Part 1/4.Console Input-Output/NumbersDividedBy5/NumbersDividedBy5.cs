using System;

class NumbersDividedBy5
{
    static void Main()
    {
        Console.WriteLine("Enter first number :");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number :");
        int secondNum = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("The numbers divided by 5 between the numbers are : ");
        Console.WriteLine(p);
    }
}

