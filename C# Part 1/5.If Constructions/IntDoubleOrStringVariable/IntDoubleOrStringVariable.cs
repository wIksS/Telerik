//  Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//  The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleOrStringVariable
{
    static void Main()
    {
        Console.WriteLine("String , int or double ?");
        sbyte choice = sbyte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number+1);
                break;
            case 2: double num = double.Parse(Console.ReadLine());
                Console.WriteLine(num+1);
                break;
            case 3: string str = Console.ReadLine();
                Console.WriteLine(str+"*");
                break;
            default:
                Console.WriteLine("The value is not correct");
                break;
        }
    }
}

